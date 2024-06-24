using System.ComponentModel.DataAnnotations;

namespace invoiceAPI.Models
{
    public class CustomerInputModel
    {
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
