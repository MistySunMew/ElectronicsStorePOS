using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStorePOS.Models
{
    /// <summary>
    /// Represent's a relation between two Products
    /// </summary>
    [PrimaryKey("Product1ID", "Product2ID")]
    public class ProductRelation
    {
        /// <summary>
        /// The first individual Product's ID
        /// </summary>
        public int Product1ID { get; set; }

        /// <summary>
        /// The second individual Product's ID
        /// </summary>
        public int Product2ID { get; set; }

        /// <summary>
        /// The relation "rating" of two Products;
        /// how related they are to each other (1 - 5 inclusive)
        /// </summary>
        [Range(1, 5)]
        public byte RelationRating { get; set; }
    }
}
