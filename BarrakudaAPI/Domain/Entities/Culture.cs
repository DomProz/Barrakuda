﻿namespace Domain.Entities
{
    public class Culture : AuditableEntity
    {
        public int Id { get; set; }
        public ECulture Category { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public ECondition Condition { get; set; }
    }
}