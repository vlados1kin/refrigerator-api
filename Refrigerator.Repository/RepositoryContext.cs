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
            .WithMany(p => p.FridgeProducts)
            .HasForeignKey(fp => fp.ProductId);
        
        modelBuilder
            .Entity<FridgeProduct>()
            .HasOne(fp => fp.Fridge)
            .WithMany(f => f.FridgeProducts)
            .HasForeignKey(fp => fp.FridgeId);
        
        modelBuilder
            .Entity<Fridge>()
            .HasOne(f => f.Model)
            .WithMany(m => m.Fridges)
            .HasForeignKey(f => f.ModelId);
        
        base.OnModelCreating(modelBuilder);
    }
}