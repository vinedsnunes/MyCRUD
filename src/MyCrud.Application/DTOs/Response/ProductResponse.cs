using MyCrud.Domain.Entities;

namespace MyCrud.Application.DTOs.Reponse
{
    public class ProductResponse
    {
        public ProductResponse(int id, string code, string name, string description, decimal price, DateTime dateRegister)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
            Price = price;
            DateRegister = dateRegister;
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateRegister { get; set; }

        public static ProductResponse ConvertToResponse(Product product)
        {
            return new ProductResponse
            (
                product.Id,
                product.Code,
                product.Name,
                product.Description,
                product.Price,
                product.DateRegister
            );
        }

    }
}
