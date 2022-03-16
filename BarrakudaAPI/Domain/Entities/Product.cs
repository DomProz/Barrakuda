﻿namespace Domain.Entities
{
    public class Product : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
        public string Condition { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Pieces { get; set; }
        public decimal Price { get; set; }
    }
}
