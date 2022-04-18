﻿namespace Core.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
