using Core.Entities;
using Core.Queries;
using DAL.Queries;
using LaCheff.Models.RecipeModels;
using Microsoft.AspNetCore.Mvc;

namespace LaCheff.Controllers
{
    [Route("recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IQueryHandler<GetRecipeQuery, IList<Recipe>> _getRecipeQuery;
        public RecipeController(
            IQueryHandler<GetRecipeQuery, IList<Recipe>> getRecipeQuery)
        {
            _getRecipeQuery = getRecipeQuery;
        }

        [HttpGet]
        public async Task<IActionResult> GetRecipe()
        {
            IList<Recipe> recipes = await _getRecipeQuery.HandleAsync(new GetRecipeQuery());
            var recipeResponse = recipes.Select(x => new RecipeResponseModel(x));

            return Ok(recipes);
        }
    }
}
