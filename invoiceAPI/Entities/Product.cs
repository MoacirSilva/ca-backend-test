using System.ComponentModel.DataAnnotations;

namespace invoiceAPI.Entities
{
    public class Product
    {
        public Product(Guid id, string name) 
        {
            Id = id;
            Name = name;
        }

        [Required]
        public Guid Id { get; set; }
        [Required] 
        public string Name { get; set; }
    }
}
