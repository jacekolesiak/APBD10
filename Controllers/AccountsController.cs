using Microsoft.AspNetCore.Mvc;
using Zadanie10.Services;

namespace Zadanie10.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController(IAccountsService accountsService) : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IResult> GetAccountById(int id)
    {
        try
        {
            var account = await accountsService.GetAccountByIdAsync(id);
            return Results.Ok(account);
        }
        catch (Exception e)
        {
            return Results.NotFound(e.Message);
        }
    }
}