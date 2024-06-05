using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10.Models;

public class ProductsCategories
{
    [Key, Column(Order = 0)]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Key, Column(Order = 1)]
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}