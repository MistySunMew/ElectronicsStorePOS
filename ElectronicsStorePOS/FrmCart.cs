using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicsStorePOS
{
    public partial class FrmCart : Form
    {
        /// <summary>
        /// Creates a cart form with the given product list
        /// </summary>
        /// <param name="productCart"></param>
        public FrmCart(List<Product> productCart)
        {
            // Clear the form's cart
            formCart.Clear();

            // Transfer all products in sent cart to form's cart 
            foreach (Product currProduct in productCart)
            {
                formCart.Add(currProduct);
            }

            InitializeComponent();
        }

        /// <summary>
        /// The Product cart
        /// </summary>
        private readonly List<Product> formCart = new();

        private void FrmCart_Load(object sender, EventArgs e)
        { 
            PopulateProductsInCartLst();
        }

        /// <summary>
        /// When called, clears the Products list-box, 
        /// and re-populates it with all Product's present in the cart
        /// </summary>
        public void PopulateProductsInCartLst()
        {
            // Clear the Products list-box
            lstProductsInCart.Items.Clear();

            // Populate the Products list-box with all products in Cart
            foreach (Product currProduct in formCart)
            {
                // Display the Product's name and price
                lstProductsInCart.Items.Add(currProduct);
            }
        }
    }
}
