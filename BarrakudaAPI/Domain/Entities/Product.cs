namespace Domain.Entities
{
    public class Product : AuditableEntity, IShopProperties
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ECategory Category { get; set; }
        public ESubCategory SubCategory { get; set; }
        public ECondition Condition { get; set; }
        public string Brand { get; set; } = string.Empty;
        public int Pieces { get; set; }
        public decimal Price { get; set; }
    }
}
