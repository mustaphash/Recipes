using Core.Commands;
using Core.Entities;
using Core.Queries;
using DAL.Commands;
using DAL.Commands.ProductCommands;
using DAL.Queries;
using LaCheff.Models.ProductModel;
using LaCheff.Models.RecipeModels;
using Microsoft.AspNetCore.Mvc;

namespace LaCheff.Controllers
{
    [Route("recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IQueryHandler<GetRecipeQuery, IList<Recipe>> _getRecipeQuery;
        private readonly ICommandHandler<CreateRecipeCommand> _crateRecipeCommand;
        private readonly ICommandHandler<CreateProductCommand> _createProductCommand;
        public RecipeController(
            IQueryHandler<GetRecipeQuery, IList<Recipe>> getRecipeQuery,
            ICommandHandler<CreateRecipeCommand> crateRecipeCommand,
            ICommandHandler<CreateProductCommand> createProductCommand)
        {
            _getRecipeQuery = getRecipeQuery;
            _crateRecipeCommand = crateRecipeCommand;
            _createProductCommand = createProductCommand;
        }

        [HttpGet]
        public async Task<IActionResult> GetRecipe()
        {
            IList<Recipe> recipes = await _getRecipeQuery.HandleAsync(new GetRecipeQuery());
            var recipeResponse = recipes.Select(x => new RecipeResponseModel(x));

            return Ok(recipes);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe(CreateRecipeModel model)
        {
            var recipe = model.ToRecipe();
            await _crateRecipeCommand.HandleAsync(new CreateRecipeCommand(recipe));

            return NoContent();
        }

        [HttpPost("products")]
        public async Task<IActionResult> InsertProduct(CreateProductModel model)
        {
            var product = model.ToProduct();
            await _createProductCommand.HandleAsync(new CreateProductCommand(model.RecipeId, product));

            return NoContent();
        }
    }
}
