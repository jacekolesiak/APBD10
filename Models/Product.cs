using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Weight { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Width { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Height { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Depth { get; set; }

    public ICollection<ProductsCategories> ProductsCategories { get; set; }
    public ICollection<ShoppingCart> ShoppingCarts { get; set; }
}