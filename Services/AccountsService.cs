using Microsoft.EntityFrameworkCore;
using Zadanie10.Contexts;
using Zadanie10.ResponseModels;

namespace Zadanie10.Services;

public interface IAccountsService
{
    Task<GetAccountByIdResponseModel> GetAccountByIdAsync(int id);
}

public class AccountsService(DatabaseContext databaseContext) : IAccountsService
{
    public async Task<GetAccountByIdResponseModel> GetAccountByIdAsync(int id)
    {
        var result = await databaseContext.Accounts
            .Where(a => a.AccountId == id)
            .Select(a => new GetAccountByIdResponseModel()
            {
                FirstName = a.FirstName,
                LastName = a.LastName,
                Email = a.Email,
                Phone = a.Phone,
                Role = a.Role.Name,
                CartDetails = a.ShoppingCarts.Select(e => new CartDetails()
                {
                    ProductId = e.ProductId,
                    ProductName = e.Product.Name,
                    Amount = e.Amount
                }).ToList()
            }).FirstOrDefaultAsync();

        if (result is null)
        {
            throw new Exception($"Account with id:{id} does not exist");
        }

        return result;
    }
}