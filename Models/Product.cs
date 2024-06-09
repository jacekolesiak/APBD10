using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10.Models;

[Table("Products")]
public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string Name { get; set; }

    [Column("weight", TypeName = "decimal(5, 2)")]
    public double Weight { get; set; }

    [Column("width", TypeName = "decimal(5, 2)")]
    public double Width { get; set; }

    [Column("height",TypeName = "decimal(5, 2)")]
    public double Height { get; set; }

    [Column("depth", TypeName = "decimal(5, 2)")]
    public double Depth { get; set; }

    public ICollection<ProductCategory> ProductsCategories { get; set; }
    public ICollection<ShoppingCart> ShoppingCarts { get; set; }
}