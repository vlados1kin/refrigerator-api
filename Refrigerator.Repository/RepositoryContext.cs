﻿using Microsoft.EntityFrameworkCore;
using Refrigerator.Domain.Configurations;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Repository;

public sealed class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<FridgeProduct>? Nodes { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Fridge>? Fridges { get; set; }
    public DbSet<Model>? Models { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new NodeConfiguration());
        modelBuilder.ApplyConfiguration(new FridgeConfiguration());
        modelBuilder.ApplyConfiguration(new ModelConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}