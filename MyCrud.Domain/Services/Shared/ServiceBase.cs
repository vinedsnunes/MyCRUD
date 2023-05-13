using MyCrud.Domain.Entities.Shared;
using MyCrud.Domain.Interfaces.Repositories.Shared;
using MyCrud.Domain.Interfaces.Services.Shared;

namespace MyCrud.Domain.Services.Shared
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        protected ServiceBase(IRepositoryBase<TEntity> repositoryBase) =>
            _repositoryBase = repositoryBase;

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await _repositoryBase.GetAllAsync();

        public virtual async Task<TEntity?> GetByIdAsync(int id) =>
            await _repositoryBase.GetByIdAsync(id);

        public virtual async Task<int> AddAsync(TEntity entity) =>
            await _repositoryBase.AddAsync(entity);

        public virtual async Task UpdateAsync(TEntity entity) =>
            await _repositoryBase.UpdateAsync(entity);

        public virtual async Task RemoveAsync(TEntity entity) =>
            await _repositoryBase.RemoveAsync(entity);

        public virtual async Task RemoveByIdAsync(int id) =>
            await _repositoryBase.RemoveByIdAsync(id);

        public void Dispose() =>
            _repositoryBase.Dispose();
    }
}
