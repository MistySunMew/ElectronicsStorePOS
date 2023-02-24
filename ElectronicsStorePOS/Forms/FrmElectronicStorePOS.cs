using ElectronicsStorePOS.Data;
using ElectronicsStorePOS.Forms;
using ElectronicsStorePOS.Models;
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
            // Add all sorting options to the sorting category combo-box
            cbxSortingCategory.Items.Add("Category - Ascending");
            cbxSortingCategory.Items.Add("Category - Descending");
            cbxSortingCategory.Items.Add("Name - Ascending");
            cbxSortingCategory.Items.Add("Name - Descending");
            cbxSortingCategory.Items.Add("Price - Ascending");
            cbxSortingCategory.Items.Add("Price - Descending");

            // Populate the Products list-box
            PopulateProductsLst();
        }

        /// <summary>
        /// The various available categories you can sort Product's by
        /// </summary>
        public enum SortingCategories
        {
            CategoryASC, CategoryDESC, 
            NameASC, NameDESC, 
            PriceASC, PriceDESC
        }

        
        /// <summary>
        /// Keeps track of the currently applied sorting category
        /// </summary>
        private readonly SortingCategories selectedSortingCategory;

        /// <summary>
        /// Added temporarily to not break project
        /// </summary>
        private void PopulateProductsLst()
        {
            PopulateProductsLstSorted(selectedSortingCategory);
        }

        /// <summary>
        /// When called, clears the Products list-box, 
        /// and re-populates it with updated data from the db,
        /// sorted in the specified manner
        /// </summary>
        private void PopulateProductsLstSorted(SortingCategories sortBy)
        {
            // Clear the Products list-box
            lstProducts.Items.Clear();

            // Create an empty list to store all Products in the db
            List<Product> allProducts = new();

            // Get all Products from the db, sorted in the specified manner
            switch (sortBy)
            {
                case SortingCategories.CategoryASC:
                    // Get all products in the db, ordered by Category
                    allProducts = GetAllProducts(sortBy);
                    break;
                case SortingCategories.CategoryDESC:
                    // Get all products in the db, ordered by Category
                    allProducts = GetAllProducts(sortBy);

                    // Sort the given list in Descending order
                    allProducts.Reverse();
                    break;
                case SortingCategories.NameASC:
                    break;
                case SortingCategories.NameDESC:
                    break;
                case SortingCategories.PriceASC:
                    break;
                case SortingCategories.PriceDESC:
                    break;
                default:
                    break;
            }

            // Populate the Products list-box with all products in db
            foreach (Product currProduct in allProducts)
            {
                // Display the Product's name and price
                lstProducts.Items.Add(currProduct);
            }
        }

        /// <summary>
        /// When called, gets and returns a list containing all Products in the db
        /// </summary>
        /// <returns>A list containing all Products in the db</returns>
        private List<Product> GetAllProducts(SortingCategories sortBy)
        {
            // Establish connection to db
            using ProductContext dbContext = new();

            // Create an empty list to store all Products in the db
            List<Product> allProducts = new();

            // Get all Products in db, sorted in the specified manner
            switch (sortBy)
            {
                case SortingCategories.CategoryASC:
                case SortingCategories.CategoryDESC:
                    // Get all Products in the db, ordered by Category
                    allProducts = dbContext.Products.OrderBy(product => product.Category).ToList();
                    break;

                case SortingCategories.NameASC:
                case SortingCategories.NameDESC:
                    // Get all Products in the db, ordered by Name
                    allProducts = dbContext.Products.OrderBy(product => product.Name).ToList();
                    break;

                case SortingCategories.PriceASC:
                case SortingCategories.PriceDESC:
                    // Get all Products in the db, ordered by Price
                    allProducts = dbContext.Products.OrderBy(product => product.Price).ToList();
                    break;
            }

            // Return the list of all Products in the db
            return allProducts;
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
            FrmCart cartForm = new(frmMainProductCart);

            // Display it to the user
            cartForm.ShowDialog();

            // Reset the main form's product cart
            frmMainProductCart.Clear();

            // Transfer the contents of the cart form's cart to the main form's cart
            foreach (Product currProduct in FrmCart.frmCartProductCart)
            {
                frmMainProductCart.Add(currProduct);
            }

            DisableButtons();
        }

        /// <summary>
        /// The main form's version of the Product cart
        /// </summary>
        readonly List<Product> frmMainProductCart = new();

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
                frmMainProductCart.Add(selectedProduct);

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

        /*************
         *** OTHER ***
         *************/

        /// <summary>
        /// If a Product has been selected, enables all Product modification buttons
        /// </summary>
        private void LstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                btnAddToCart.Enabled = true;
                btnDeleteProduct.Enabled = true;
                btnOpenUpdateProductForm.Enabled = true;
            }
        }

        /// <summary>
        /// Disables all main form button's that require a Product to be selected
        /// </summary>
        private void DisableButtons() 
        {
            btnAddToCart.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnOpenUpdateProductForm.Enabled = false;
        }

        /// <summary>
        /// When the "Credits" link is clicked, displays the Credits form
        /// </summary>
        private void LlbCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCredits creditsForm = new();
            creditsForm.ShowDialog();
        }
    }
}