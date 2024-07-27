using Microsoft.EntityFrameworkCore;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Repository;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Node>? Notes { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Fridge>? Fridges { get; set; }
    public DbSet<Model>? Models { get; set; }
}