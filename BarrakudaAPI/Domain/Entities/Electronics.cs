namespace Domain.Entities
{
    public class Electronics : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public EElectronics Category { get; set; }
        public ECondition Condition { get; set; }
        public string Brand { get; set; } = String.Empty;
    }
}
