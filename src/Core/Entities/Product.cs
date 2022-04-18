﻿namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }

        public Recipe Recipe { get; set; }
    }
}
