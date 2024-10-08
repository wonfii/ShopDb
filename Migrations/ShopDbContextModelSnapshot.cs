﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hw_ShopDb;

#nullable disable

namespace hw_ShopDb.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductShop", b =>
                {
                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.Property<int>("ShopsShopId")
                        .HasColumnType("int");

                    b.HasKey("ProductsProductId", "ShopsShopId");

                    b.HasIndex("ShopsShopId");

                    b.ToTable("ProductShop");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Books"
                        });
                });

            modelBuilder.Entity("hw_ShopDb.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CountryId = 1,
                            Name = "New York"
                        },
                        new
                        {
                            CityId = 2,
                            CountryId = 1,
                            Name = "Los Angeles"
                        },
                        new
                        {
                            CityId = 3,
                            CountryId = 2,
                            Name = "Toronto"
                        });
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            Name = "USA"
                        },
                        new
                        {
                            CountryId = 2,
                            Name = "Canada"
                        });
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PositionId");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            PositionId = 1,
                            Name = "Manager"
                        },
                        new
                        {
                            PositionId = 2,
                            Name = "Cashier"
                        });
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Discount = 0f,
                            IsInStock = false,
                            Name = "Laptop",
                            Price = 999.99m,
                            Quantity = 0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Discount = 0f,
                            IsInStock = false,
                            Name = "Smartphone",
                            Price = 499.99m,
                            Quantity = 0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Discount = 0f,
                            IsInStock = false,
                            Name = "Fiction Book",
                            Price = 19.99m,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Shop", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShopId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("ParkingArea")
                        .HasColumnType("int");

                    b.HasKey("ShopId");

                    b.HasIndex("CityId");

                    b.ToTable("Shop");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Address = "123 Tech Road",
                            CityId = 1,
                            Name = "TechStore"
                        },
                        new
                        {
                            ShopId = 2,
                            Address = "456 Book Street",
                            CityId = 2,
                            Name = "BookStore"
                        });
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Worker", b =>
                {
                    b.Property<int>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PoditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("WorkerId");

                    b.HasIndex("PoditionId");

                    b.HasIndex("ShopId");

                    b.ToTable("Worker");

                    b.HasData(
                        new
                        {
                            WorkerId = 1,
                            Email = "john.doe@example.com",
                            Name = "John",
                            PhoneNumber = "555-1234",
                            PoditionId = 1,
                            Salary = 60000m,
                            ShopId = 1,
                            Surname = "Doe"
                        },
                        new
                        {
                            WorkerId = 2,
                            Email = "jane.smith@example.com",
                            Name = "Jane",
                            PhoneNumber = "555-5678",
                            PoditionId = 2,
                            Salary = 45000m,
                            ShopId = 2,
                            Surname = "Smith"
                        },
                        new
                        {
                            WorkerId = 3,
                            Email = "mike.johnson@example.com",
                            Name = "Mike",
                            PhoneNumber = "555-8765",
                            PoditionId = 2,
                            Salary = 40000m,
                            ShopId = 1,
                            Surname = "Johnson"
                        });
                });

            modelBuilder.Entity("ProductShop", b =>
                {
                    b.HasOne("hw_ShopDb.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hw_ShopDb.Entities.Shop", null)
                        .WithMany()
                        .HasForeignKey("ShopsShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("hw_ShopDb.Entities.City", b =>
                {
                    b.HasOne("hw_ShopDb.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Product", b =>
                {
                    b.HasOne("hw_ShopDb.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Shop", b =>
                {
                    b.HasOne("hw_ShopDb.Entities.City", "City")
                        .WithMany("Shops")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Worker", b =>
                {
                    b.HasOne("hw_ShopDb.Entities.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PoditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hw_ShopDb.Entities.Shop", "Shop")
                        .WithMany("Workers")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.City", b =>
                {
                    b.Navigation("Shops");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Position", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("hw_ShopDb.Entities.Shop", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
