using Core.Commands;
using Core.Entities;

namespace DAL.Commands
{
    public class CreateRecipeCommand : ICommand
    {
        public CreateRecipeCommand(Recipe recipe)
        {
            Recipe = recipe;
        }
        public Recipe Recipe { get; }
    }
}
