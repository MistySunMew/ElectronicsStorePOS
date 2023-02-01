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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProductsInCart
            // 
            this.lstProductsInCart.FormattingEnabled = true;
            this.lstProductsInCart.ItemHeight = 20;
            this.lstProductsInCart.Location = new System.Drawing.Point(26, 29);
            this.lstProductsInCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProductsInCart.Name = "lstProductsInCart";
            this.lstProductsInCart.Size = new System.Drawing.Size(311, 204);
            this.lstProductsInCart.TabIndex = 4;
            this.lstProductsInCart.SelectedIndexChanged += new System.EventHandler(this.LstProductsInCart_SelectedIndexChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(19, 31);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 20);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(88, 27);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(146, 27);
            this.txtSubTotal.TabIndex = 6;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxTotal
            // 
            this.txtTaxTotal.Enabled = false;
            this.txtTaxTotal.Location = new System.Drawing.Point(88, 66);
            this.txtTaxTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxTotal.Name = "txtTaxTotal";
            this.txtTaxTotal.Size = new System.Drawing.Size(146, 27);
            this.txtTaxTotal.TabIndex = 8;
            this.txtTaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(50, 70);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(33, 20);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(88, 105);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(146, 27);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(41, 109);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // btnRemoveProductFromCart
            // 
            this.btnRemoveProductFromCart.Enabled = false;
            this.btnRemoveProductFromCart.Location = new System.Drawing.Point(497, 180);
            this.btnRemoveProductFromCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveProductFromCart.Name = "btnRemoveProductFromCart";
            this.btnRemoveProductFromCart.Size = new System.Drawing.Size(120, 53);
            this.btnRemoveProductFromCart.TabIndex = 11;
            this.btnRemoveProductFromCart.Text = "Remove Product";
            this.btnRemoveProductFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveProductFromCart.Click += new System.EventHandler(this.BtnRemoveProductFromCart_Click);
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.Location = new System.Drawing.Point(367, 180);
            this.btnReturnHome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(120, 53);
            this.btnReturnHome.TabIndex = 30;
            this.btnReturnHome.Text = "Return Home";
            this.btnReturnHome.UseVisualStyleBackColor = true;
            this.btnReturnHome.Click += new System.EventHandler(this.BtnReturnHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtTaxTotal);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Location = new System.Drawing.Point(367, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 150);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // FrmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.btnRemoveProductFromCart);
            this.Controls.Add(this.lstProductsInCart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.FrmCart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox groupBox1;
    }
}