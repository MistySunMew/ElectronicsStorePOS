using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStorePOS
{
    internal class Product
    {
        /// <summary>
        /// The Primary key identity column
        /// </summary>
        public required int ProductID { get; set; }

        /// <summary>
        /// The Product's name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// The sales price of the Product
        /// </summary>
        [Range(0, Double.MaxValue)]
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
    }
}
