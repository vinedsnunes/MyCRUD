using MyCrud.Domain.Entities;
using MyCrud.Domain.Interfaces.Repositories;
using MyCrud.Domain.Interfaces.Services;
using MyCrud.Domain.Services.Shared;

namespace MyCrud.Domain.Services
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        public ProductService(IProductRepository productRepository) : base(productRepository) { }
    }
}
