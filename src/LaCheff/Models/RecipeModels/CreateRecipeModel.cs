using Core.Entities;

namespace LaCheff.Models.RecipeModels
{
    public class CreateRecipeModel
    {
        public string Name { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }

        public Recipe ToRecipe()
        {
            return new Recipe
            {
                Name = Name,
                Instructions = Instructions,
                Description = Description,
            };
        }
    }
}
