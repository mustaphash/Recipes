using Core.Commands;
using Core.Entities;
using Core.Queries;
using DAL;
using DAL.Commands;
using DAL.Commands.ProductCommands;
using DAL.Queries;
using DAL.Queries.ProductQueries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<RecipeContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddScoped<IQueryHandler<GetRecipeQuery, IList<Recipe>>, GetRecipeQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetProductsQuery, IList<Product>>, GetProductsQueryHandler>();

builder.Services.AddScoped<ICommandHandler<CreateRecipeCommand>, CreateRecipeCommandHandler>();
builder.Services.AddScoped<ICommandHandler<CreateProductCommand>, CreateProductCommandHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
