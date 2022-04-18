using Core.Entities;
using LaCheff.Models.ProductModel;

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
            Products = recipe.Products.Select(x => new ProductResponseModel(x));
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        public string Description { get; set; }

        public IEnumerable<ProductResponseModel> Products { get; set; }
    }
}
