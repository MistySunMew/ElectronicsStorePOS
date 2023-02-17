using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStorePOS
{
    /// <summary>
    /// Represent's a product currently being sold
    /// </summary>
    public class Product
    {
        /// <summary>
        /// The Primary key identity column
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// The Product's name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// The sales price of the Product
        /// </summary>
        [Range(0, double.MaxValue)]
        public required double Price { get; set; }

        /// <summary>
        /// The Product's description
        /// </summary>
        public string? Desc { get; set; }
        
        /// <summary>
        /// The Product's ESRB rating
        /// </summary>
        public string? Rating { get; set; }

        /// <summary>
        /// The category the Product belongs in
        /// </summary>
        public required string Category { get; set; }

        /// <summary>
        /// The Product's Stock Keeping Unit
        /// </summary>
        public required string SKU { get; set; }

        /// <summary>
        /// Returns a products name and price as a string 
        /// to represent the object when displayed
        /// </summary>
        /// <returns>The Product's name and price as a string</returns>
        public override string ToString()
        {
            return $"{Name} - {Price:c}";
        }
    }
}
