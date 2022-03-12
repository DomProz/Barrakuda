namespace Domain.Entities
{
    public class Fashion : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EFashion Category { get; set; }
        public ECondition Condition { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
    }
}
