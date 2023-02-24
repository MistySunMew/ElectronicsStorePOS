using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicsStorePOS.Data;
using ElectronicsStorePOS.Models;

namespace ElectronicsStorePOS
{
    public partial class FrmCreateProduct : Form
    {
        public FrmCreateProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds items to comboboxes
        /// </summary>
        private void FrmCreateProduct_Load(object sender, EventArgs e)
        {
            cbxGameRating.Items.Add("E");
            cbxGameRating.Items.Add("E10+");
            cbxGameRating.Items.Add("T");
            cbxGameRating.Items.Add("M");
            cbxGameRating.Items.Add("AO");
            cbxGameRating.Items.Add("RP");

            cbxProductCategory.Items.Add("Console");
            cbxProductCategory.Items.Add("Game");
            cbxProductCategory.Items.Add("Accessory");
            cbxProductCategory.Items.Add("PC Component");
            cbxProductCategory.Items.Add("Storage Device");
            cbxProductCategory.Items.Add("Display");
            cbxProductCategory.Items.Add("Software");
            cbxProductCategory.Items.Add("Other");

            clearClicked = 0;
        }

        /// <summary>
        /// Closes the current form
        /// </summary>
        private void BtnReturnHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Takes inputs from form and creates a new Product object that gets added to the database
        /// </summary>
        private void BtnCreateProduct_Click(object sender, EventArgs e)
        {
            clearClicked = 0;
            if (IsValid()) {
                Product newProduct = new()
                {
                    Name = txtProductName.Text,
                    Price = Convert.ToDouble(txtProductPrice.Text),
                    Desc = txtProductDesc.Text,
                    Category = cbxProductCategory.Text,
                    SKU = txtProductSKU.Text,
                };

                using ProductContext dbContext = new();

                if (cbxProductCategory.Text == "Game")
                {
                    newProduct.Rating = cbxGameRating.Text;
                }

                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();

                // Display message indicating successful operation
                Validation.DisplayMessage($"{newProduct.Name} was created successfully",
                                           "Product Created");
                BtnClearForm_Click(sender, e);
            }
        }

        /// <summary>
        /// Clears the form
        /// </summary>
        private void BtnClearForm_Click(object sender, EventArgs e)
        {
            clearClicked++;
            txtProductDesc.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductSKU.Clear();
            cbxGameRating.SelectedItem = null;
            cbxProductCategory.SelectedItem = null;
            if (clearClicked == 3) 
            {
                switch1.Enabled = true;
                switch1.Visible = true;
            }
            else if (clearClicked > 3)
            {
                cbxStepTwo.Enabled = false;
                cbxStepTwo.Visible = false;
                switch1.Enabled = false;
                switch1.Visible = false;
            }
        }

        /// <summary>
        /// Enables or disables cbxGameRating depending on what category is selected
        /// </summary>
        private void CbxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearClicked = 0;
            if (cbxProductCategory.Text == "Game")
            {
                cbxGameRating.Enabled = true;
            }
            else
            {
                cbxGameRating.SelectedItem = null;
                cbxGameRating.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if all inputs are valid and gives user feedback if not implemented properly
        /// </summary>
        /// <returns>True if everything is valid</returns>
        public bool IsValid()
        {
            if (!Validation.IsInputPresent(txtProductName))
            {
                Validation.DisplayMessage("Please enter a Name", "Input Error");
                return false;
            }
            else if (!Validation.IsNumber(txtProductPrice.Text))
            {
                Validation.DisplayMessage("Please enter a valid price", "Input Error");
                return false;
            }
            else if (!Validation.IsCategory(cbxProductCategory.Text))
            {
                Validation.DisplayMessage("Please choose a Category", "Input Error");
                return false;
            }
            else if (cbxProductCategory.Text == "Game" && !Validation.IsRating(cbxGameRating.Text)) 
            {
                Validation.DisplayMessage("Please choose a Rating", "Input Error");
                return false;
            }
            else if (!Validation.IsInputPresent(txtProductSKU))
            {
                Validation.DisplayMessage("Please enter a SKU", "Input Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        private int clearClicked;
        private void Switch1_CheckedChanged(object sender, EventArgs e)
        {
            if (switch1.Checked)
            {
                cbxStepTwo.Enabled = true;
                cbxStepTwo.Visible = true;
            }
            else 
            {
                cbxStepTwo.Enabled = false;
                cbxStepTwo.Visible = false;
            }
        }

		private void CbxStepTwo_CheckedChanged(object sender, EventArgs e)
		{
            this.Size = new Size(Size.Width, Size.Height + 300);
            txtNonsense.Visible = true;
		}

		private void TxtNonsense_Click(object sender, EventArgs e)
		{
			this.Size = new Size(Size.Width, Size.Height + 300);
            btnQuit.Visible = true;
            btnNewAll.Visible = true;
		}

		private void BtnQuit_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void BtnNewAll_Click(object sender, EventArgs e)
		{
            FrmTest frmTest = new();
            frmTest.Show();
		}
	}
}
