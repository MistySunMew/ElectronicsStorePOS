﻿// <auto-generated />
using ElectronicsStorePOS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronicsStorePOS.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230217202448_ProductRelation")]
    partial class ProductRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElectronicsStorePOS.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Category = "Console",
                            Name = "PlayStation 5",
                            Price = 499.99000000000001,
                            SKU = "6426149"
                        },
                        new
                        {
                            ProductID = 2,
                            Category = "Console",
                            Name = "PlayStation 5 Digital Edition",
                            Price = 399.99000000000001,
                            SKU = "6430161"
                        },
                        new
                        {
                            ProductID = 3,
                            Category = "Game",
                            Name = "Horizon Forbidden West",
                            Price = 69.989999999999995,
                            Rating = "T",
                            SKU = "6479466"
                        },
                        new
                        {
                            ProductID = 4,
                            Category = "Game",
                            Name = "Demon Souls",
                            Price = 69.989999999999995,
                            Rating = "M",
                            SKU = "6430152"
                        },
                        new
                        {
                            ProductID = 5,
                            Category = "Game",
                            Name = "Sackboy: A Big Adventure",
                            Price = 59.990000000000002,
                            Rating = "E",
                            SKU = "6430149"
                        },
                        new
                        {
                            ProductID = 6,
                            Category = "Game",
                            Name = "Marvel's Spider-Man: Miles Morales",
                            Price = 49.990000000000002,
                            Rating = "T",
                            SKU = "6430146"
                        },
                        new
                        {
                            ProductID = 7,
                            Category = "Game",
                            Name = "Gran Turismo 7",
                            Price = 69.989999999999995,
                            Rating = "T",
                            SKU = "6501071"
                        },
                        new
                        {
                            ProductID = 8,
                            Category = "Game",
                            Name = "The Nioh Collection",
                            Price = 69.989999999999995,
                            Rating = "M",
                            SKU = "6442989"
                        },
                        new
                        {
                            ProductID = 9,
                            Category = "Game",
                            Name = "Ratchet & Clank: Rift Apart",
                            Price = 69.989999999999995,
                            Rating = "E10+",
                            SKU = "6463683"
                        },
                        new
                        {
                            ProductID = 10,
                            Category = "Game",
                            Name = "UNCHARTED: Legacy of Thieves Collection",
                            Price = 49.990000000000002,
                            Rating = "T",
                            SKU = "6491840"
                        },
                        new
                        {
                            ProductID = 11,
                            Category = "Game",
                            Name = "The Last of Us Part 1",
                            Price = 69.989999999999995,
                            Rating = "M",
                            SKU = "6510195"
                        },
                        new
                        {
                            ProductID = 12,
                            Category = "Game",
                            Name = "Destruction AllStars",
                            Price = 19.989999999999998,
                            Rating = "T",
                            SKU = "6459523"
                        },
                        new
                        {
                            ProductID = 13,
                            Category = "Accessory",
                            Name = "Astro A30 Headphones",
                            Price = 229.99000000000001,
                            SKU = "6515569"
                        },
                        new
                        {
                            ProductID = 14,
                            Category = "Accessory",
                            Name = "Astro A10 Headphones",
                            Price = 59.990000000000002,
                            SKU = "6224200"
                        },
                        new
                        {
                            ProductID = 15,
                            Category = "Accessory",
                            Name = "Astro A40 Headphones",
                            Price = 129.99000000000001,
                            SKU = "6278220"
                        },
                        new
                        {
                            ProductID = 16,
                            Category = "Accessory",
                            Name = "Blue Yeti Microphone",
                            Price = 129.99000000000001,
                            SKU = "9737441"
                        },
                        new
                        {
                            ProductID = 17,
                            Category = "Accessory",
                            Name = "Blue Snowball Microphone",
                            Price = 69.989999999999995,
                            SKU = "9918056"
                        },
                        new
                        {
                            ProductID = 18,
                            Category = "Accessory",
                            Name = "Razer BlackWidow V3 Keyboard",
                            Price = 139.99000000000001,
                            SKU = "6425360"
                        },
                        new
                        {
                            ProductID = 19,
                            Category = "Accessory",
                            Name = "Razer Naga Trinity Mouse",
                            Price = 69.989999999999995,
                            SKU = "6172049"
                        },
                        new
                        {
                            ProductID = 20,
                            Category = "Accessory",
                            Name = "Logitech G715 Keyboard",
                            Price = 199.99000000000001,
                            SKU = "6511306"
                        },
                        new
                        {
                            ProductID = 21,
                            Category = "Accessory",
                            Name = "Logitech G502 X PLUS LIGHTSPEED Mouse",
                            Price = 159.99000000000001,
                            SKU = "6512122"
                        },
                        new
                        {
                            ProductID = 22,
                            Category = "Accessory",
                            Name = "SteelSeries - Apex 3 Keyboard",
                            Price = 39.990000000000002,
                            SKU = "6396205"
                        },
                        new
                        {
                            ProductID = 23,
                            Category = "Accessory",
                            Name = "SteelSeries - Aerox 3 Mouse",
                            Price = 39.990000000000002,
                            SKU = "6485248"
                        },
                        new
                        {
                            ProductID = 24,
                            Category = "PC Component",
                            Name = "Intel Core i9-13900F",
                            Price = 609.99000000000001,
                            SKU = "N82E1689118412"
                        },
                        new
                        {
                            ProductID = 25,
                            Category = "PC Component",
                            Name = "Intel Core i7-11700KF",
                            Price = 269.99000000000001,
                            SKU = "9SIBGW5J9X8036"
                        },
                        new
                        {
                            ProductID = 26,
                            Category = "PC Component",
                            Name = "AMD Ryzen 9 5950X",
                            Price = 799.0,
                            SKU = "N82E1689113663"
                        },
                        new
                        {
                            ProductID = 27,
                            Category = "PC Component",
                            Name = "AMD Ryzen 5 7600X",
                            Price = 2249.0,
                            SKU = "N82E1689113770"
                        },
                        new
                        {
                            ProductID = 28,
                            Category = "PC Component",
                            Name = "GIGABYTE B550 AM4 Motherboard",
                            Price = 139.99000000000001,
                            SKU = "N82E16813145433"
                        },
                        new
                        {
                            ProductID = 29,
                            Category = "PC Component",
                            Name = "EVGA Z790 LGA1700 Motherboard",
                            Price = 699.99000000000001,
                            SKU = "N82E16813188206"
                        },
                        new
                        {
                            ProductID = 30,
                            Category = "PC Component",
                            Name = "NVIDIA GeForce RTX 4080",
                            Price = 11999.99,
                            SKU = "6521431"
                        },
                        new
                        {
                            ProductID = 31,
                            Category = "PC Component",
                            Name = "AMD Radeon RX 7900 XTX",
                            Price = 999.0,
                            SKU = "6528715"
                        },
                        new
                        {
                            ProductID = 32,
                            Category = "Storage Device",
                            Name = "Seagate IronWolf 16TB Hard Drive",
                            Price = 249.99000000000001,
                            SKU = "6459355"
                        },
                        new
                        {
                            ProductID = 33,
                            Category = "Storage Device",
                            Name = "Samsung 980 PRO 2000GB SSD",
                            Price = 199.99000000000001,
                            SKU = "6485009"
                        },
                        new
                        {
                            ProductID = 34,
                            Category = "Storage Device",
                            Name = "SanDisk 512GB Flash Drive",
                            Price = 47.990000000000002,
                            SKU = "6422265"
                        },
                        new
                        {
                            ProductID = 35,
                            Category = "Display",
                            Name = "Samsung 55\" LED 4K TV",
                            Price = 399.99000000000001,
                            SKU = "6401735"
                        },
                        new
                        {
                            ProductID = 36,
                            Category = "Display",
                            Name = "LG 86\" LED 4K TV",
                            Price = 1499.99,
                            SKU = "6525091"
                        },
                        new
                        {
                            ProductID = 37,
                            Category = "Display",
                            Name = "Samsung 32\" 4K Monitor",
                            Price = 399.99000000000001,
                            SKU = "6401735"
                        },
                        new
                        {
                            ProductID = 38,
                            Category = "Display",
                            Name = "AORUS 43\" 4K Monitor",
                            Price = 749.99000000000001,
                            SKU = "6483970"
                        },
                        new
                        {
                            ProductID = 39,
                            Category = "Software",
                            Name = "TurboTax Deluxe 2022",
                            Price = 55.990000000000002,
                            SKU = "6518337"
                        },
                        new
                        {
                            ProductID = 40,
                            Category = "Software",
                            Name = "Adobe Photoshop Elements 2023",
                            Price = 79.989999999999995,
                            SKU = "6517623"
                        },
                        new
                        {
                            ProductID = 41,
                            Category = "Software",
                            Name = "Office Home",
                            Price = 149.99000000000001,
                            SKU = "6474446"
                        },
                        new
                        {
                            ProductID = 42,
                            Category = "Software",
                            Name = "Windows 11 Home",
                            Price = 139.0,
                            SKU = "6498482"
                        },
                        new
                        {
                            ProductID = 43,
                            Category = "Software",
                            Name = "Adobe Acrobat Standard",
                            Price = 358.99000000000001,
                            SKU = "6434506"
                        });
                });

            modelBuilder.Entity("ElectronicsStorePOS.ProductRelation", b =>
                {
                    b.Property<int>("Product1ID")
                        .HasColumnType("int");

                    b.Property<int>("Product2ID")
                        .HasColumnType("int");

                    b.Property<byte>("RelationRating")
                        .HasColumnType("tinyint");

                    b.HasKey("Product1ID", "Product2ID");

                    b.ToTable("ProductRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
