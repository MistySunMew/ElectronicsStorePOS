using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStorePOS
{
    /// <summary>
    /// Represent's a relation between two Products
    /// </summary>
    public class ProductRelation
    {
        /// <summary>
        /// The first individual Product being sold
        /// </summary>
        public Product Product1 { get; set; }

        /// <summary>
        /// The second individual Product being sold
        /// </summary>
        public Product Product2 { get; set; }

        /// <summary>
        /// The relation "rating" of two Products;
        /// how related they are to each other (1 - 5 inclusive)
        /// </summary>
        [Range(1, 5)]
        public byte RelationRating { get; set; }
    }
}
