namespace Domain.Entities
{
    public class Culture : AuditableEntity
    {
        public int Id { get; set; }
        public ECulture Category { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ECondition Condition { get; set; }
    }
}
