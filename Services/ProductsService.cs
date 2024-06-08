using Microsoft.EntityFrameworkCore;
using Zadanie10.Contexts;
using Zadanie10.Exceptions;
using Zadanie10.Models;
using Zadanie10.RequestModels;

namespace Zadanie10.Services;

public interface IProductsService
{
    Task AddProductAndCategoriesAsync(AddProductAndCategoriesRequestModel request);
}
public class ProductsService(DatabaseContext databaseContext) : IProductsService
{
    public async Task AddProductAndCategoriesAsync(AddProductAndCategoriesRequestModel request)
    {
        var newProduct = new Product
        {
            Name = request.ProductName,
            Depth = request.ProductDepth,
            Height = request.ProductHeight,
            Weight = request.ProductWeight,
            Width = request.ProductWidth,
        };

        await databaseContext.Products.AddAsync(newProduct);

        // Select ... Where in (Select ...)
        // Select all categories (from the database) that are in the list of categories (from the request)
        var categories = await databaseContext.Categories.Where(e => request.ProductCategories.Any(e2 => e.CategoryId == e2)).Select(e => e.CategoryId).ToListAsync();
        
        // Check if all (from the request) categories exist (in the database)
        // If you don't find a category from the request in the database, throw an exception
        request.ProductCategories.ForEach(e =>
        {
            if (!categories.Contains(e))
            {
                throw new NotFoundException($"Category with id:{e} does not exist");
            }
        });

        var productCategories = request.ProductCategories.Select(e => new ProductsCategories()
        {
            Product = newProduct,
            CategoryId = e
        });

        await databaseContext.ProductsCategories.AddRangeAsync(productCategories);

        await databaseContext.SaveChangesAsync();
    }
}