using MyCrud.Domain.Entities;

namespace MyCrud.Application.DTOs.Request
{
    public class PostProductRequest
    {
        public PostProductRequest(string code, string name, string description, decimal price)
        {
            Code = code;
            Name = name;
            Description = description;
            Price = price;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public static Product ConvertToEntity(PostProductRequest request)
        {
            return new Product
            (
                request.Code,
                request.Name,
                request.Description,
                request.Price
            );
        }
    }
}
