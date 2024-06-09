using System.ComponentModel.DataAnnotations;

namespace Zadanie10.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<ProductCategory> ProductsCategories { get; set; }
}