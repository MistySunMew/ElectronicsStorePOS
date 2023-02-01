namespace ElectronicsStorePOS
{
    partial class FrmCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProductsInCart = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTaxTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemoveProductFromCart = new System.Windows.Forms.Button();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProductsInCart
            // 
            this.lstProductsInCart.FormattingEnabled = true;
            this.lstProductsInCart.ItemHeight = 15;
            this.lstProductsInCart.Location = new System.Drawing.Point(23, 22);
            this.lstProductsInCart.Name = "lstProductsInCart";
            this.lstProductsInCart.Size = new System.Drawing.Size(273, 154);
            this.lstProductsInCart.TabIndex = 4;
            this.lstProductsInCart.SelectedIndexChanged += new System.EventHandler(this.LstProductsInCart_SelectedIndexChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(380, 37);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 15);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(440, 34);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubTotal.TabIndex = 6;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxTotal
            // 
            this.txtTaxTotal.Enabled = false;
            this.txtTaxTotal.Location = new System.Drawing.Point(440, 63);
            this.txtTaxTotal.Name = "txtTaxTotal";
            this.txtTaxTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTaxTotal.TabIndex = 8;
            this.txtTaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(407, 66);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(27, 15);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(440, 92);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(399, 95);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // btnRemoveProductFromCart
            // 
            this.btnRemoveProductFromCart.Enabled = false;
            this.btnRemoveProductFromCart.Location = new System.Drawing.Point(435, 136);
            this.btnRemoveProductFromCart.Name = "btnRemoveProductFromCart";
            this.btnRemoveProductFromCart.Size = new System.Drawing.Size(105, 40);
            this.btnRemoveProductFromCart.TabIndex = 11;
            this.btnRemoveProductFromCart.Text = "Remove Product";
            this.btnRemoveProductFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveProductFromCart.Click += new System.EventHandler(this.BtnRemoveProductFromCart_Click);
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.Location = new System.Drawing.Point(435, 181);
            this.btnReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(105, 40);
            this.btnReturnHome.TabIndex = 30;
            this.btnReturnHome.Text = "Return Home";
            this.btnReturnHome.UseVisualStyleBackColor = true;
            this.btnReturnHome.Click += new System.EventHandler(this.BtnReturnHome_Click);
            // 
            // FrmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.btnRemoveProductFromCart);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTaxTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lstProductsInCart);
            this.Name = "FrmCart";
            this.Text = "FrmCart";
            this.Load += new System.EventHandler(this.FrmCart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstProductsInCart;
        private Label lblSubtotal;
        private TextBox txtSubTotal;
        private TextBox txtTaxTotal;
        private Label lblTax;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnRemoveProductFromCart;
        private Button btnReturnHome;
    }
}