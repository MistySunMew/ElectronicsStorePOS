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
            CalculateAndOutputTotals();
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

        /// <summary>
        /// Calculates the subtotal, tax total, and total of all Products 
        /// present in the cart, and output them to their corresponding textboxes
        /// </summary>
        public void CalculateAndOutputTotals()
        {
            // Calculate the subtotal of all Products in cart
            double subtotal = 0;

            // Run through cart
            foreach (Product currProduct in formCart)
            {
                // Add the Product's price to subtotal
                subtotal += currProduct.Price;
            }

            // Calculate the tax total
            double TAX_RATE = .10;
            double taxTotal = subtotal * TAX_RATE;

            // Calculate the total of all Products in cart
            double total = subtotal + taxTotal;

            // Output all total's to form
            txtSubTotal.Text = $"{subtotal:c}";
            txtTaxTotal.Text = $"{taxTotal:c}";
            txtTotal.Text = $"{total:c}";
        }
    }
}
