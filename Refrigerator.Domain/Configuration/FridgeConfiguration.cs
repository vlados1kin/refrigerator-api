﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configuration;

public class FridgeConfiguration : IEntityTypeConfiguration<Fridge>
{
    public void Configure(EntityTypeBuilder<Fridge> builder)
    {
        builder.HasData
        (
            new Fridge()
            {
                Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "Atlant",
                OwnerName = "IITP",
                ModelId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
            },
            new Fridge()
            {
                Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "BOSCH",
                OwnerName = "IITP",
                ModelId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
            }
        );
    }
}