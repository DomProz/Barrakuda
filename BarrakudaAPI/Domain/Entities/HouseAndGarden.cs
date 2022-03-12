namespace Domain.Entities
{
    public class HouseAndGarden : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EHouseAndGarden Category { get; set; }
        public ECondition Condition { get; set; }
        public string Brand { get; set; } = string.Empty;
    }
}

