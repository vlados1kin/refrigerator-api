using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configuration;

public class FridgeProductConfiguration : IEntityTypeConfiguration<FridgeProduct>
{
    public void Configure(EntityTypeBuilder<FridgeProduct> builder)
    {
        builder.HasData
        (
            new FridgeProduct()
            {
                Id = new Guid("c9d4c053-49b5-410c-bc78-2d54a9991870"),
                FridgeId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                ProductId = new Guid("a9d4c053-49b6-410c-bc78-2d54a9991870")
            },
            new FridgeProduct()
            {
                Id = new Guid("c9d4c053-49b1-410c-bc78-2d54a9991870"),
                FridgeId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                ProductId = new Guid("1d490a70-94ce-4d15-9494-5248280c2ce3")
            },
            new FridgeProduct()
            {
                Id = new Guid("b9d4c053-49b5-410c-bc78-2d54a9991870"),
                FridgeId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                ProductId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
            }
        );
    }
}