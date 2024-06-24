using System.ComponentModel.DataAnnotations;

namespace invoiceAPI.Entities
{
    public class Customer
    {
        public Customer(Guid id, string name, string email, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            Address = address;

        }
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        
    }
}
