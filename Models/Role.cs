using System.ComponentModel.DataAnnotations;

namespace Zadanie10.Models;

public class Role
{
    [Key]
    public int RoleId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<Account> Accounts { get; set; }
}