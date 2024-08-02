using Microsoft.EntityFrameworkCore;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Repository;

public sealed class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<FridgeProduct>? FridgeProducts { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Fridge>? Fridges { get; set; }
    public DbSet<Model>? Models { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<FridgeProduct>()
            .HasOne(fp => fp.Product)
            .WithOne(p => p.FridgeProduct)
            .HasForeignKey<FridgeProduct>(fp => fp.ProductId);
        
        modelBuilder
            .Entity<FridgeProduct>()
            .HasOne(fp => fp.Fridge)
            .WithOne(f => f.FridgeProduct)
            .HasForeignKey<FridgeProduct>(fp => fp.FridgeId);
        
        modelBuilder
            .Entity<Fridge>()
            .HasOne(f => f.Model)
            .WithOne(m => m.Fridge)
            .HasForeignKey<Fridge>(f => f.ModelId);
        
        base.OnModelCreating(modelBuilder);
    }
}