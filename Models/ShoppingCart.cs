using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10.Models;

public class ShoppingCart
{
    [Key, Column(Order = 0)]
    [ForeignKey("Account")]
    public int AccountId { get; set; }
    public Account Account { get; set; }

    [Key, Column(Order = 1)]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int Amount { get; set; }
}