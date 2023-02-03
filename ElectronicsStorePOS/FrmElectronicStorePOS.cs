using Microsoft.VisualBasic;
using System.Numerics;

namespace ElectronicsStorePOS
{
	public partial class FrmElectronicStorePOS : Form
	{
		public FrmElectronicStorePOS()
		{
			InitializeComponent();
		}

        /// <summary>
        /// When the "Create Product" button is clicked, creates 
        /// and displays an instance of the CreateProduct form
        /// </summary>
        private void BtnOpenCreateProductForm_Click(object sender, EventArgs e)
        {
            // Create new instance of form
            FrmCreateProduct createProductForm = new();

            // Display it to the user
            createProductForm.ShowDialog();

            // Reset Products list-box
            PopulateProductsLst();

            // Disables buttons
            DisableButtons();
        }

        /// <summary>
        /// When the "Update Product" button is clicked, creates 
        /// and displays an instance of the UpdateProduct form
        /// </summary>
        private void BtnOpenUpdateProductForm_Click(object sender, EventArgs e)
        {
            // Create new instance of form
            FrmUpdateProduct updateProductForm = new((Product) lstProducts.SelectedItem);

            // Display it to the user
            updateProductForm.ShowDialog();

            // Reset Products list-box
            PopulateProductsLst();

            // Disables buttons
            DisableButtons();
        }

        /**************
         *** DELETE ***
         **************/

        /// <summary>
        /// When the "Delete Product" button is clicked, 
        /// removes the selected product from the database
        /// </summary>
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Establish connection to db
            using ProductContext dbContext = new();

            // Get the currently selected Product
            Product selectedProduct = (Product)lstProducts.SelectedItem;

            // Setup delete query
            dbContext.Remove(selectedProduct);

            // Push the query to db
            dbContext.SaveChanges();

            // Reset the list-box
            PopulateProductsLst();

            // Display message to user
            Validation.DisplayMessage($"{selectedProduct.Name} was deleted successfully", 
                                       "Product Deleted");

            // Disables buttons
            DisableButtons();
        }

        /**************
         *** SELECT ***
         **************/

        /// <summary>
        /// When "Home" form is opened, displays all Products in db
        /// </summary>
        private void FrmElectronicStorePOS_Load(object sender, EventArgs e)
        {
            // Populate the Products list-box
            PopulateProductsLst();
        }

        /// <summary>
        /// When called, clears the Products list-box, 
        /// and re-populates it with updated data from the db
        /// </summary>
        public void PopulateProductsLst()
        {
            // Clear the Products list-box
            lstProducts.Items.Clear();

            // Get all Products in the db
            List<Product> allProducts = GetAllProducts();

            // Populate the Products list-box with all products in db
            foreach (Product currProduct in allProducts)
            {
                // Display the Product's name and price
                lstProducts.Items.Add(currProduct);
            }
        }

        /************
         *** CART ***
         ************/

        /// <summary>
        /// When the "Cart" button is clicked, creates 
        /// and displays an instance of the Cart form
        /// </summary>
        private void BtnOpenCartForm_Click(object sender, EventArgs e)
        {
            // Create new instance of form using the product cart
            FrmCart cartForm = new(productCart);

            // Display it to the user
            cartForm.ShowDialog();

            // Reset the product cart
            productCart.Clear();

            // Transfer the content's of the form cart to the product cart
            foreach (Product currProduct in FrmCart.productCart)
            {
                productCart.Add(currProduct);
            }

            DisableButtons();
        }

        /// <summary>
        /// When called, gets and returns a list containing all Products in the db
        /// </summary>
        /// <returns>A list containing all Products in the db</returns>
        private List<Product> GetAllProducts()
        {
            // Establish connection to db
            using ProductContext dbContext = new();

            // Get all Products in db
            List<Product> allProducts = dbContext.Products.ToList();

            // Return the list
            return allProducts;
        }

        /// <summary>
        /// The Product cart
        /// </summary>
        readonly List<Product> productCart = new();

        /// <summary>
        /// When the "Add To Cart" button is clicked, if a Product
        /// is selected, adds it to the cart
        /// </summary>
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            // Check if a Product has been selected
            if(lstProducts.SelectedIndex != -1)
            {
                // Get the selected Product
                Product selectedProduct = (Product)lstProducts.SelectedItem;

                // Add it to the cart
                productCart.Add(selectedProduct);

                // Display message indicating successful operation
                Validation.DisplayMessage($"{selectedProduct.Name} was added successfully to the cart",
                                           "Product Added To Cart");

                // Reset the Product list
                lstProducts.SelectedIndex = -1;

                DisableButtons();
            }

            // Otherwise
            else
            {
                // Display error
                Validation.DisplayError("Please select a product to add to the cart", 
                                        "Item Not Selected");
            }
        }

        private void LstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                btnAddToCart.Enabled = true;
                btnDeleteProduct.Enabled = true;
                btnOpenUpdateProductForm.Enabled = true;
            }
        }

        private void DisableButtons() 
        {
            btnAddToCart.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnOpenUpdateProductForm.Enabled = false;
        }
    }
}