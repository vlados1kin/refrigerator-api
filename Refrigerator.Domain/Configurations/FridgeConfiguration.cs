using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configurations;

public class FridgeConfiguration : IEntityTypeConfiguration<Fridge>
{
    public void Configure(EntityTypeBuilder<Fridge> builder)
    {
        builder.HasKey(f => f.Id);

        builder.HasOne(f => f.Node).WithOne(n => n.Fridge);

        builder.HasOne(f => f.Model).WithOne(m => m.Fridge);
    }
}