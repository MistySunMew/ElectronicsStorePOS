using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicsStorePOS.Models;

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
            FrmCart.productCart.Clear();

            // Transfer all products in sent cart to form's cart 
            foreach (Product currProduct in productCart)
            {
                FrmCart.productCart.Add(currProduct);
            }

            InitializeComponent();
        }

        /// <summary>
        /// The Product cart
        /// </summary>
        public static List<Product> productCart = new();

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
            foreach (Product currProduct in productCart)
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
            foreach (Product currProduct in productCart)
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

        /// <summary>
        /// When the "Remove Product" button is clicked, if a Product is selected, removes it from the cart
        /// </summary>
        private void BtnRemoveProductFromCart_Click(object sender, EventArgs e)
        {
            // Check if a Product has been selected
            if (lstProductsInCart.SelectedIndex != -1)
            {
                // Get the selected Product
                Product selectedProduct = (Product) lstProductsInCart.SelectedItem;

                // Remove it from the cart
                productCart.Remove(selectedProduct);

                // Reset the Products list
                PopulateProductsInCartLst();
                lstProductsInCart.SelectedIndex = -1;

                // Reset the total's
                CalculateAndOutputTotals();

                // Display message indicating successful operation
                Validation.DisplayMessage($"{selectedProduct.Name} was removed successfully from the cart",
                                           "Product Removed From Cart");

                // Disable the "Remove Product" button
                btnRemoveProductFromCart.Enabled = false;
            }

            // Otherwise
            else
            {
                // Display error
                Validation.DisplayError("Please select a product to remove from the cart",
                                        "Item Not Selected");
            }
        }

        /// <summary>
        /// When a Product is selected, enables the "Remove Product" button
        /// </summary>
        private void LstProductsInCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductsInCart.SelectedIndex != -1)
            {
                btnRemoveProductFromCart.Enabled = true;
            }
        }

        /// <summary>
        /// When the "Return Home" button is clicked, closes the Cart Form
        /// </summary>
        private void BtnReturnHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
