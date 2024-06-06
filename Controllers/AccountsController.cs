using Microsoft.AspNetCore.Mvc;
using Zadanie10.Services;

namespace Zadanie10.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController : ControllerBase
{
    [HttpGet("{id:int}")]
    public async Task<IResult> GetAccountById(IAccountsService accountsService, int id)
    {
        var account = await accountsService.GetAccountByIdAsync(id);
        if (account == null)
        {
            return Results.NotFound($"Account with id: {id} not found.");
        }
        return Results.Ok(account);
    }
}