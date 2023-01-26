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
    public partial class FrmUpdateProduct : Form
    {
        public FrmUpdateProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds items to comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUpdateProduct_Load(object sender, EventArgs e)
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
        }


        /// <summary>
        /// Closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Takes inputs from form and updates the current Product object that gets updated in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtProductDesc.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductSKU.Clear();
            cbxGameRating.SelectedItem = null;
            cbxProductCategory.SelectedItem = null;
        }

        /// <summary>
        /// Enables or disables cbxGameRating depending on what category is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        public bool isValid()
        {
            if (!Validation.IsInputPresent(txtProductName))
            {
                Validation.DisplayMessage("Please Enter a Name", "Input Error");
                return false;
            }
            else if (!Validation.IsNumber(txtProductPrice.Text))
            {
                Validation.DisplayMessage("Please Enter a valid price", "Input Error");
                return false;
            }
            else if (!Validation.IsCategory(cbxProductCategory.Text))
            {
                Validation.DisplayMessage("Please Choose a Category", "Input Error");
                return false;
            }
            else if (cbxProductCategory.Text == "Game" && !Validation.IsRating(cbxGameRating.Text))
            {
                Validation.DisplayMessage("Please Choose a Rating", "Input Error");
                return false;
            }
            else if (!Validation.IsInputPresent(txtProductSKU))
            {
                Validation.DisplayMessage("Please Enter a SKU", "Input Error");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
