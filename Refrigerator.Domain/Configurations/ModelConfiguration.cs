using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configurations;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasKey(m => m.Id);

        builder.HasOne(m => m.Fridge).WithOne(f => f.Model);
    }
}