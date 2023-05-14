using MyCrud.Domain.Entities.Shared;

namespace MyCrud.Domain.Entities
{
    public class Product : Entity
    {

        public string Code { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; set; }
        public DateTime DateRegister { get; private set; }

        public Product(int id, string code, string name, string description, decimal price)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
            Price = price;
            DateRegister = DateTime.Now;
        }

        public Product(string code, string name, string description, decimal price)
        : this(default, code, name, description, price) { }
    }
}
