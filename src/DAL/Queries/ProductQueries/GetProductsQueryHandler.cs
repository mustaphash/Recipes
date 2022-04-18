using Core.Entities;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.ProductQueries
{
    public class GetProductsQueryHandler : IQueryHandler<GetProductsQuery, IList<Product>>
    {
        private readonly RecipeContext _recipeContext;
        public GetProductsQueryHandler(RecipeContext recipeContext)
        {
            _recipeContext = recipeContext;
        }
        public async Task<IList<Product>> HandleAsync(GetProductsQuery query, CancellationToken cancellationToken = default)
        {
            List<Product> products = await _recipeContext.Products.ToListAsync(cancellationToken);

            return products;
        }
    }
}
