using System.ComponentModel.DataAnnotations;

namespace invoiceAPI.Models
{
    public class ProductInputModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
