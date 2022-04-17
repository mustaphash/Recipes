using Core.Entities;

namespace LaCheff.Models.RecipeModels
{
    public class RecipeResponseModel
    {
        public RecipeResponseModel(Recipe recipe)
        {
            Id = recipe.Id;
            Name = recipe.Name;
            Instructions = recipe.Instructions;
            Description = recipe.Description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }
    }
}
