namespace Domain.Entities
{
    public class Automotive : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public EAutomotive Category { get; set; }
        public ECondition Condition { get; set; }
        public string Brand { get; set; } = String.Empty;
    }
}
