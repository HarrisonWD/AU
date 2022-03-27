﻿// <auto-generated />
using AU.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AU.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220327150242_ProductVariants")]
    partial class ProductVariants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AU.Shared.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hoodies",
                            Url = "hoodie"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Beanies",
                            Url = "beanie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "T-Shirts",
                            Url = "tshirt"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mugs",
                            Url = "mug"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chairs",
                            Url = "chair"
                        });
                });

            modelBuilder.Entity("AU.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Warm and cosey, available in mutliple colours and sizes.",
                            Image = "hoodie",
                            Name = "Hoodie"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Stylish headwear to keep warm as well as represent the team",
                            Image = "beanie",
                            Name = "Beanie"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            Description = "Customised and ergonimically designed mug for the warmest brews",
                            Image = "",
                            Name = "Mug"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Stylish 2019 Edition Team T-Shirt",
                            Image = "tshirt",
                            Name = "T-Shirt"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Styilish 2020 Edition Team Hoodie",
                            Image = "hoodie2020",
                            Name = "Hoodie 2020E"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 5,
                            Description = "Secret Labs sponsor chair",
                            Image = "chair",
                            Name = "Secret Chair"
                        });
                });

            modelBuilder.Entity("AU.Shared.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Small"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Medium"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Large"
                        },
                        new
                        {
                            Id = 5,
                            Name = "XLarge"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Standard"
                        });
                });

            modelBuilder.Entity("AU.Shared.Models.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            OriginalPrice = 15.99m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 1,
                            OriginalPrice = 15.99m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 1,
                            OriginalPrice = 15.99m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 1,
                            OriginalPrice = 15.99m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 1,
                            OriginalPrice = 15.99m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 6,
                            OriginalPrice = 299.99m,
                            Price = 249.99m
                        });
                });

            modelBuilder.Entity("AU.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DarkTheme")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Notifications")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AU.Shared.Models.Product", b =>
                {
                    b.HasOne("AU.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AU.Shared.Models.ProductVariant", b =>
                {
                    b.HasOne("AU.Shared.Models.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AU.Shared.Models.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("AU.Shared.Models.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
