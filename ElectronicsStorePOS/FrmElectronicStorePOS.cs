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
        }

        /// <summary>
        /// When the "Update Product" button is clicked, creates 
        /// and displays an instance of the UpdateProduct form
        /// </summary>
        private void BtnOpenUpdateProductForm_Click(object sender, EventArgs e)
        {
            // Create new instance of form
            FrmUpdateProduct updateProductForm = new();

            // Display it to the user
            updateProductForm.ShowDialog();

            // Reset Products list-box
            PopulateProductsLst();
        }

        /// <summary>
        /// When the "Delete Product" button is clicked, 
        /// removes the selected product from the database
        /// </summary>
        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// When the "Cart" button is clicked, creates 
        /// and displays an instance of the Cart form
        /// </summary>
        private void BtnOpenCartForm_Click(object sender, EventArgs e)
        {
            // Create new instance of form
            FrmCart cartForm = new();

            // Display it to the user
            cartForm.ShowDialog();
        }

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
        List<Product> productCart = new();

        /// <summary>
        /// When a product is selected, adds it to the cart
        /// </summary>
        private void LstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected product
            Product selectedProduct = (Product) lstProducts.SelectedItem;

            // Add it to the cart
            productCart.Add(selectedProduct);
        }
    }
}