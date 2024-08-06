﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Refrigerator.Repository;

#nullable disable

namespace Refrigerator.API.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240803173225_AddData")]
    partial class AddData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Refrigerator.Domain.Entities.Fridge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FridgeId");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Fridges");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            ModelId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Name = "Atlant",
                            OwnerName = "IITP"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            ModelId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Name = "BOSCH",
                            OwnerName = "IITP"
                        });
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.FridgeProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FridgeProductId");

                    b.Property<Guid>("FridgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FridgeId");

                    b.HasIndex("ProductId");

                    b.ToTable("FridgeProducts");
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ModelId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Name = "MC-123-AE",
                            Year = 2015
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Name = "AB-1234-QQ",
                            Year = 2014
                        });
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProductId");

                    b.Property<int>("DefaultQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.Fridge", b =>
                {
                    b.HasOne("Refrigerator.Domain.Entities.Model", "Model")
                        .WithMany("Fridges")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.FridgeProduct", b =>
                {
                    b.HasOne("Refrigerator.Domain.Entities.Fridge", "Fridge")
                        .WithMany("FridgeProducts")
                        .HasForeignKey("FridgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Refrigerator.Domain.Entities.Product", "Product")
                        .WithMany("FridgeProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fridge");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.Fridge", b =>
                {
                    b.Navigation("FridgeProducts");
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.Model", b =>
                {
                    b.Navigation("Fridges");
                });

            modelBuilder.Entity("Refrigerator.Domain.Entities.Product", b =>
                {
                    b.Navigation("FridgeProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
