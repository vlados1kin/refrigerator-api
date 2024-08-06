using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refrigerator.Domain.Entities;

namespace Refrigerator.Domain.Configuration;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.HasData
        (
            new Model()
            {
                Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                Name = "MC-123-AE",
                Year = 2015
            },
            new Model()
            {
                Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                Name = "AB-1234-QQ",
                Year = 2014
            }
        );
    }
}