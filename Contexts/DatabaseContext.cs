using Microsoft.EntityFrameworkCore;
using Zadanie10.Models;

namespace Zadanie10.Contexts;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public DbSet<ProductCategory> ProductsCategories { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<ProductsCategories>()
    //         .HasKey(pc => new { pc.ProductId, pc.CategoryId });
    //     
    //     modelBuilder.Entity<ShoppingCart>()
    //         .HasKey(sc => new { sc.AccountId, sc.ProductId });
    // }
}