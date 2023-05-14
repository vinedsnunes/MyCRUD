using MyCrud.Data.Context;
using MyCrud.Data.Repositories.Shared;
using MyCrud.Domain.Entities;
using MyCrud.Domain.Interfaces.Repositories;

namespace MyCrud.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context) { }
    }
}
