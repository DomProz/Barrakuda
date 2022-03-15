using System.ComponentModel.DataAnnotations;

namespace Application.Models.Product
{
    public class UpdateProductDto
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public int Pieces { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
