﻿namespace Domain.Entities
{
    public class Fashion : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public EFashion Category { get; set; }
        public ECondition Condition { get; set; }
        public string Brand { get; set; } = String.Empty;
        public string Size { get; set; } = String.Empty;
    }
}