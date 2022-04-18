using Core.Commands;
using Core.Entities;

namespace DAL.Commands.ProductCommands
{
    public class CreateProductCommand : ICommand
    {
        public CreateProductCommand(int id, Product product)
        {
            RecipeId = id;
            Product = product;
        }
        public int RecipeId { get; }
        public Product Product { get; }
    }
}
