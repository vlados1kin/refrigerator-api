using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData
        (
            new Product()
            {
                Id = new Guid("a9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "Cucumber",
                DefaultQuantity = 10,
            },
            new Product()
            {
                Id = new Guid("1d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "Apple",
                DefaultQuantity = 5,
            },
            new Product()
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Name = "Watermelon",
                DefaultQuantity = 3,
            }
        );
    }
}