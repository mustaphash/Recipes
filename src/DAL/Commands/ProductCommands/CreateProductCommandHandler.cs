using Core.Commands;
using Microsoft.EntityFrameworkCore;

namespace DAL.Commands.ProductCommands
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
    {
        private readonly RecipeContext _recipeContext;
        public CreateProductCommandHandler(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }
        public async Task HandleAsync(CreateProductCommand command, CancellationToken cancellationToken = default)
        {
            var recipe = _recipeContext.Recipes.Include(p => p.Products).FirstOrDefaultAsync(x=>x.Id == command.RecipeId);
            if (recipe != null)
            {
                _recipeContext.Products.Add(command.Product);
                await _recipeContext.SaveChangesAsync();

            }
        }
    }
}
