using MyCrud.Domain.Entities;

namespace MyCrud.Application.DTOs.Request
{
    public class PutProductRequest
    {
        public PutProductRequest(string code, string name, string description, decimal price)
        {
            Code = code;
            Name = name;
            Description = description;
            Price = price;
        }
        
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public static Product ConvertToEntity(PutProductRequest request)
        {
            return new Product
            (
                request.Id,
                request.Code,
                request.Name,
                request.Description,
                request.Price
            );
        }
    }
}
