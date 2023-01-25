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
    }
}
