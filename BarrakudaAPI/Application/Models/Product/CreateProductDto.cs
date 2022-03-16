using System.ComponentModel.DataAnnotations;

namespace Application.Models.Product
{
    public class CreateProductDto
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        [Required]
        public int Pieces { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
