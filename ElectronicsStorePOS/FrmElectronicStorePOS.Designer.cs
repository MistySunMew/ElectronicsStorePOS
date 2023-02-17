namespace ElectronicsStorePOS
{
	partial class FrmElectronicStorePOS
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnOpenCreateProductForm = new System.Windows.Forms.Button();
            this.btnOpenUpdateProductForm = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnOpenCartForm = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCreateProductForm
            // 
            this.btnOpenCreateProductForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCreateProductForm.Location = new System.Drawing.Point(398, 28);
            this.btnOpenCreateProductForm.Name = "btnOpenCreateProductForm";
            this.btnOpenCreateProductForm.Size = new System.Drawing.Size(105, 40);
            this.btnOpenCreateProductForm.TabIndex = 0;
            this.btnOpenCreateProductForm.Text = "Create \r\nProduct";
            this.btnOpenCreateProductForm.UseVisualStyleBackColor = true;
            this.btnOpenCreateProductForm.Click += new System.EventHandler(this.BtnOpenCreateProductForm_Click);
            // 
            // btnOpenUpdateProductForm
            // 
            this.btnOpenUpdateProductForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenUpdateProductForm.Enabled = false;
            this.btnOpenUpdateProductForm.Location = new System.Drawing.Point(398, 93);
            this.btnOpenUpdateProductForm.Name = "btnOpenUpdateProductForm";
            this.btnOpenUpdateProductForm.Size = new System.Drawing.Size(105, 40);
            this.btnOpenUpdateProductForm.TabIndex = 1;
            this.btnOpenUpdateProductForm.Text = "Update Product";
            this.btnOpenUpdateProductForm.UseVisualStyleBackColor = true;
            this.btnOpenUpdateProductForm.Click += new System.EventHandler(this.BtnOpenUpdateProductForm_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(398, 158);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(105, 40);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete \r\nProduct";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(32, 28);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(332, 304);
            this.lstProducts.TabIndex = 3;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.LstProducts_SelectedIndexChanged);
            // 
            // btnOpenCartForm
            // 
            this.btnOpenCartForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCartForm.Location = new System.Drawing.Point(398, 289);
            this.btnOpenCartForm.Name = "btnOpenCartForm";
            this.btnOpenCartForm.Size = new System.Drawing.Size(105, 40);
            this.btnOpenCartForm.TabIndex = 4;
            this.btnOpenCartForm.Text = "Go To \r\nCart";
            this.btnOpenCartForm.UseVisualStyleBackColor = true;
            this.btnOpenCartForm.Click += new System.EventHandler(this.BtnOpenCartForm_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.Location = new System.Drawing.Point(398, 224);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(105, 40);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add To \r\nCart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // FrmElectronicStorePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnOpenCartForm);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnOpenUpdateProductForm);
            this.Controls.Add(this.btnOpenCreateProductForm);
            this.Name = "FrmElectronicStorePOS";
            this.Text = "Electronic Store POS";
            this.Load += new System.EventHandler(this.FrmElectronicStorePOS_Load);
            this.ResumeLayout(false);

		}

        #endregion

        private Button btnOpenCreateProductForm;
        private Button btnOpenUpdateProductForm;
        private Button btnDeleteProduct;
        private ListBox lstProducts;
        private Button btnOpenCartForm;
        private Button btnAddToCart;
    }
}