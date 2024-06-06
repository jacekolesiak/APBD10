namespace Zadanie10.ResponseModels;

public class GetAccountByIdResponseModel
{
    public string FirstName { get; set; }
    public string LastName{ get; set; }
    public string Email{ get; set; }
    public string Phone{ get; set; }
    public string Role{ get; set; }
    public List<CartDetails> CartDetails{ get; set; }
}

public class CartDetails
{
    public int ProductId{ get; set; }
    public string ProductName{ get; set; }
    public int Amount{ get; set; }
}