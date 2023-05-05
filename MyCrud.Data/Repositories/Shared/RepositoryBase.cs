using Microsoft.EntityFrameworkCore;
using MyCrud.Data.Context;
using MyCrud.Domain.Entities.Shared;
using MyCrud.Domain.Interfaces.Repositories.Shared;

namespace MyCrud.Data.Repositories.Shared
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected readonly DataContext _context;

        public RepositoryBase(DataContext context) =>
            _context = context;

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await _context.Set<TEntity>()
            .AsNoTracking()
            .ToListAsync();

        public virtual async Task<TEntity?> GetByIdAsync(int id) =>
            await _context.Set<TEntity>().FindAsync(id);

        public virtual async Task<int> AddAsync(TEntity entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity.Id;
        }

        public virtual async Task RemoveAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task RemoveByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            if (entity is null)
                throw new Exception("The record does not exist in the database.");

            await RemoveAsync(entity);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public void Dispose() =>
            _context.Dispose();
    }
}
