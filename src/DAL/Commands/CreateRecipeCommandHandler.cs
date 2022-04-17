using Core.Commands;

namespace DAL.Commands
{
    public class CreateRecipeCommandHandler : ICommandHandler<CreateRecipeCommand>
    {
        private readonly RecipeContext _recipeContext;
        public CreateRecipeCommandHandler(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }

        public async Task HandleAsync(CreateRecipeCommand command, CancellationToken cancellationToken = default)
        {
             await _recipeContext.AddAsync(command.Recipe);
            await _recipeContext.SaveChangesAsync();
        }
    }
}
