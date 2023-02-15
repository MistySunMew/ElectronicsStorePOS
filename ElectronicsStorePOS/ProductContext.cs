using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStorePOS
{
    internal class ProductContext : DbContext
    {
        public ProductContext() 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ElectronicsStoreProducts;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //TODO Delete Migration folder and local database
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, Category = "Console", Name = "PlayStation 5", Price = 499.99, SKU = "6426149" },
                new Product { ProductID = 2, Category = "Console", Name = "PlayStation 5 Digital Edition", Price = 399.99, SKU = "6430161" },
                new Product { ProductID = 3, Category = "Game", Rating = "T", Name = "Horizon Forbidden West", Price = 69.99, SKU = "6479466" },
                new Product { ProductID = 4, Category = "Game", Rating = "M", Name = "Demon Souls", Price = 69.99, SKU = "6430152" },
                new Product { ProductID = 5, Category = "Game", Rating = "E", Name = "Sackboy: A Big Adventure", Price = 59.99, SKU = "6430149" },
                new Product { ProductID = 6, Category = "Game", Rating = "T", Name = "Marvel's Spider-Man: Miles Morales", Price = 49.99, SKU = "6430146" },
                new Product { ProductID = 7, Category = "Game", Rating = "T", Name = "Gran Turismo 7", Price = 69.99, SKU = "6501071" },
                new Product { ProductID = 8, Category = "Game", Rating = "M", Name = "The Nioh Collection", Price = 69.99, SKU = "6442989" },
                new Product { ProductID = 9, Category = "Game", Rating = "E10+", Name = "Ratchet & Clank: Rift Apart", Price = 69.99, SKU = "6463683" },
                new Product { ProductID = 10, Category = "Game", Rating = "T", Name = "UNCHARTED: Legacy of Thieves Collection", Price = 49.99, SKU = "6491840" },
                new Product { ProductID = 11, Category = "Game", Rating = "M", Name = "The Last of Us Part 1", Price = 69.99, SKU = "6510195" },
                new Product { ProductID = 12, Category = "Game", Rating = "T", Name = "Destruction AllStars", Price = 19.99, SKU = "6459523" },
                new Product { ProductID = 13, Category = "Accessory", Name = "Astro A30 Headphones", Price = 229.99, SKU = "6515569" },
                new Product { ProductID = 14, Category = "Accessory", Name = "Astro A10 Headphones", Price = 59.99, SKU = "6224200" },
                new Product { ProductID = 15, Category = "Accessory", Name = "Astro A40 Headphones", Price = 129.99, SKU = "6278220" },
                new Product { ProductID = 16, Category = "Accessory", Name = "Blue Yeti Microphone", Price = 129.99, SKU = "9737441" },
                new Product { ProductID = 17, Category = "Accessory", Name = "Blue Snowball Microphone", Price = 69.99, SKU = "9918056" },
                new Product { ProductID = 18, Category = "Accessory", Name = "Razer BlackWidow V3 Keyboard", Price = 139.99, SKU = "6425360" },
                new Product { ProductID = 19, Category = "Accessory", Name = "Razer Naga Trinity Mouse", Price = 69.99, SKU = "6172049" },
                new Product { ProductID = 20, Category = "Accessory", Name = "Logitech G715 Keyboard", Price = 199.99, SKU = "6511306" },
                new Product { ProductID = 21, Category = "Accessory", Name = "Logitech G502 X PLUS LIGHTSPEED Mouse", Price = 159.99, SKU = "6512122" },
                new Product { ProductID = 22, Category = "Accessory", Name = "SteelSeries - Apex 3 Keyboard", Price = 39.99, SKU = "6396205" },
                new Product { ProductID = 23, Category = "Accessory", Name = "SteelSeries - Aerox 3 Mouse", Price = 39.99, SKU = "6485248" },
                new Product { ProductID = 24, Category = "PC Component", Name = "Intel Core i9-13900F", Price = 609.99, SKU = "N82E1689118412" },
                new Product { ProductID = 25, Category = "PC Component", Name = "Intel Core i7-11700KF", Price = 269.99, SKU = "9SIBGW5J9X8036" },
                new Product { ProductID = 26, Category = "PC Component", Name = "AMD Ryzen 9 5950X", Price = 799.00, SKU = "N82E1689113663" },
                new Product { ProductID = 27, Category = "PC Component", Name = "AMD Ryzen 5 7600X", Price = 2249.00, SKU = "N82E1689113770" },
                new Product { ProductID = 28, Category = "PC Component", Name = "GIGABYTE B550 AM4 Motherboard", Price = 139.99, SKU = "N82E16813145433" },
                new Product { ProductID = 29, Category = "PC Component", Name = "EVGA Z790 LGA1700 Motherboard", Price = 699.99, SKU = "N82E16813188206" },
                new Product { ProductID = 30, Category = "PC Component", Name = "NVIDIA GeForce RTX 4080", Price = 11999.99, SKU = "6521431" },
                new Product { ProductID = 31, Category = "PC Component", Name = "AMD Radeon RX 7900 XTX", Price = 999.00, SKU = "6528715" },
                new Product { ProductID = 32, Category = "Storage Device", Name = "Seagate IronWolf 16TB Hard Drive", Price = 249.99, SKU = "6459355" },
                new Product { ProductID = 33, Category = "Storage Device", Name = "Samsung 980 PRO 2000GB SSD", Price = 199.99, SKU = "6485009" },
                new Product { ProductID = 34, Category = "Storage Device", Name = "SanDisk 512GB Flash Drive", Price = 47.99, SKU = "6422265" },
                new Product { ProductID = 35, Category = "Display", Name = "Samsung 55\" LED 4K TV", Price = 399.99, SKU = "6401735" },
                new Product { ProductID = 36, Category = "Display", Name = "LG 86\" LED 4K TV", Price = 1499.99, SKU = "6525091" },
                new Product { ProductID = 37, Category = "Display", Name = "Samsung 32\" 4K Monitor", Price = 399.99, SKU = "6401735" },
                new Product { ProductID = 38, Category = "Display", Name = "AORUS 43\" 4K Monitor", Price = 749.99, SKU = "6483970" },
                new Product { ProductID = 39, Category = "Software", Name = "TurboTax Deluxe 2022", Price = 55.99, SKU = "6518337" },
                new Product { ProductID = 40, Category = "Software", Name = "Adobe Photoshop Elements 2023", Price = 79.99, SKU = "6517623" },
                new Product { ProductID = 41, Category = "Software", Name = "Office Home", Price = 149.99, SKU = "6474446" },
                new Product { ProductID = 42, Category = "Software", Name = "Windows 11 Home", Price = 139.00, SKU = "6498482" },
                new Product { ProductID = 43, Category = "Software", Name = "Adobe Acrobat Standard", Price = 358.99, SKU = "6434506" }
            );
        }
    }
}
