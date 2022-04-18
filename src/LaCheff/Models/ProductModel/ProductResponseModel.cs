using Core.Entities;

namespace LaCheff.Models.ProductModel
{
    public class ProductResponseModel
    {
        public ProductResponseModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
        }

        public int Id { get; }
        public string Name { get; }

        public Product ToProduct()
        {
            return new Product
            {
                Id = Id,
                Name = Name,
            };
        }
    }
}
