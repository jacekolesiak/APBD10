using Microsoft.AspNetCore.Mvc;
using Zadanie10.Exceptions;
using Zadanie10.RequestModels;
using Zadanie10.Services;

namespace Zadanie10.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(IProductsService productsService)
{
    [HttpPost]
    public async Task<IResult> AddProductAndCategoriesAsync(AddProductAndCategoriesRequestModel request)
    {
        try
        {
            await productsService.AddProductAndCategoriesAsync(request);
            return Results.NoContent();
        }
        catch (NotFoundException e)
        {
            return Results.NotFound(e.Message);
        }
    }
}