using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10.Models;

[Table("Accounts")]
public class Account
{
    [Key]
    [Column("PK_account")]
    public int AccountId { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("first_name")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    [Column("last_name")]
    public string LastName { get; set; }

    [Required]
    [MaxLength(80)]
    [Column("email")]
    public string Email { get; set; }

    [MaxLength(9)]
    [Column("phone")]
    public string Phone { get; set; }

    [ForeignKey("Role")]
    [Column("FK_role")]
    public int RoleId { get; set; }
    public Role Role { get; set; }

    public ICollection<ShoppingCart> ShoppingCarts { get; set; }    
}