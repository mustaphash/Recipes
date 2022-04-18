using Core.Entities;

namespace LaCheff.Models.ProductModel
{
    public class CreateProductModel
    {
        public string Name { get; set; }
        public int RecipeId { get; set; }

        public Product ToProduct()
        {
            return new Product
            {
                Name = Name,
            };
        }
    }
}
