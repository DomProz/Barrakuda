using Domain.Enums;

namespace Application.Models.Product
{
    public class ProductDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ECategory Category { get; set; }
        public string SubCategory { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Pieces { get; set; }
        public decimal Price { get; set; }

        public int? CreateById { get; set; }
    }
}
