using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configurations;

public class NodeConfiguration : IEntityTypeConfiguration<FridgeProduct>
{
    public void Configure(EntityTypeBuilder<FridgeProduct> builder)
    {
        builder.HasKey(n => n.Id);

        builder.HasOne(n => n.Product).WithOne(p => p.Node);

        builder.HasOne(n => n.Fridge).WithOne(f => f.Node);
    }
}