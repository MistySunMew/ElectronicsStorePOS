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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElectronicStorePOS));
            this.btnOpenCreateProductForm = new System.Windows.Forms.Button();
            this.btnOpenUpdateProductForm = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnOpenCartForm = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.llbCredits = new System.Windows.Forms.LinkLabel();
            this.cbxSortingCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenCreateProductForm
            // 
            this.btnOpenCreateProductForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCreateProductForm.Location = new System.Drawing.Point(486, 28);
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
            this.btnOpenUpdateProductForm.Location = new System.Drawing.Point(486, 94);
            this.btnOpenUpdateProductForm.Name = "btnOpenUpdateProductForm";
            this.btnOpenUpdateProductForm.Size = new System.Drawing.Size(105, 40);
            this.btnOpenUpdateProductForm.TabIndex = 1;
            this.btnOpenUpdateProductForm.Text = "Update \r\nProduct";
            this.btnOpenUpdateProductForm.UseVisualStyleBackColor = true;
            this.btnOpenUpdateProductForm.Click += new System.EventHandler(this.BtnOpenUpdateProductForm_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(486, 160);
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
            this.lstProducts.Location = new System.Drawing.Point(32, 58);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(418, 274);
            this.lstProducts.TabIndex = 3;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.LstProducts_SelectedIndexChanged);
            // 
            // btnOpenCartForm
            // 
            this.btnOpenCartForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCartForm.Location = new System.Drawing.Point(486, 292);
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
            this.btnAddToCart.Location = new System.Drawing.Point(486, 226);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(105, 40);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add To \r\nCart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.BtnAddToCart_Click);
            // 
            // llbCredits
            // 
            this.llbCredits.AutoSize = true;
            this.llbCredits.Location = new System.Drawing.Point(32, 337);
            this.llbCredits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbCredits.Name = "llbCredits";
            this.llbCredits.Size = new System.Drawing.Size(44, 15);
            this.llbCredits.TabIndex = 6;
            this.llbCredits.TabStop = true;
            this.llbCredits.Text = "Credits";
            this.llbCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbCredits_LinkClicked);
            // 
            // cbxSortingCategory
            // 
            this.cbxSortingCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSortingCategory.FormattingEnabled = true;
            this.cbxSortingCategory.Location = new System.Drawing.Point(81, 28);
            this.cbxSortingCategory.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cbxSortingCategory.Name = "cbxSortingCategory";
            this.cbxSortingCategory.Size = new System.Drawing.Size(369, 23);
            this.cbxSortingCategory.TabIndex = 27;
            this.cbxSortingCategory.SelectedIndexChanged += new System.EventHandler(this.CbxSortingCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sort By:";
            // 
            // FrmElectronicStorePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 361);
            this.Controls.Add(this.cbxSortingCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.llbCredits);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnOpenCartForm);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnOpenUpdateProductForm);
            this.Controls.Add(this.btnOpenCreateProductForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmElectronicStorePOS";
            this.Text = "Electronic Store POS";
            this.Load += new System.EventHandler(this.FrmElectronicStorePOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private Button btnOpenCreateProductForm;
        private Button btnOpenUpdateProductForm;
        private Button btnDeleteProduct;
        private ListBox lstProducts;
        private Button btnOpenCartForm;
        private Button btnAddToCart;
        private LinkLabel llbCredits;
        private ComboBox cbxSortingCategory;
        private Label label5;
    }
}