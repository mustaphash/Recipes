using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries
{
    public class GetRecipeQueryHandler : IQueryHandler<GetRecipeQuery, IList<Recipe>>
    {
        private readonly RecipeContext _recipeContext;
        public GetRecipeQueryHandler(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }
        public async Task<IList<Recipe>> HandleAsync(GetRecipeQuery query, CancellationToken cancellationToken = default)
        {
            List<Recipe> recipes = await _recipeContext.Recipes.Include(p => p.Products).ToListAsync(cancellationToken);

            return recipes;
        }
    }
}
