namespace ElectronicsStorePOS
{
    partial class FrmUpdateProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateProduct));
			this.btnReturnHome = new System.Windows.Forms.Button();
			this.btnClearForm = new System.Windows.Forms.Button();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.txtProductSKU = new System.Windows.Forms.TextBox();
			this.cbxProductCategory = new System.Windows.Forms.ComboBox();
			this.cbxGameRating = new System.Windows.Forms.ComboBox();
			this.txtProductDesc = new System.Windows.Forms.TextBox();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnReturnHome
			// 
			this.btnReturnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReturnHome.Location = new System.Drawing.Point(548, 135);
			this.btnReturnHome.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btnReturnHome.Name = "btnReturnHome";
			this.btnReturnHome.Size = new System.Drawing.Size(150, 66);
			this.btnReturnHome.TabIndex = 29;
			this.btnReturnHome.Text = "Return \r\nHome";
			this.btnReturnHome.UseVisualStyleBackColor = true;
			this.btnReturnHome.Click += new System.EventHandler(this.BtnReturnHome_Click);
			// 
			// btnClearForm
			// 
			this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClearForm.Location = new System.Drawing.Point(548, 234);
			this.btnClearForm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btnClearForm.Name = "btnClearForm";
			this.btnClearForm.Size = new System.Drawing.Size(150, 66);
			this.btnClearForm.TabIndex = 28;
			this.btnClearForm.Text = "Clear \r\nForm";
			this.btnClearForm.UseVisualStyleBackColor = true;
			this.btnClearForm.Click += new System.EventHandler(this.BtnClearForm_Click);
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdateProduct.Location = new System.Drawing.Point(548, 36);
			this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(150, 66);
			this.btnUpdateProduct.TabIndex = 27;
			this.btnUpdateProduct.Text = "Update Product";
			this.btnUpdateProduct.UseVisualStyleBackColor = true;
			this.btnUpdateProduct.Click += new System.EventHandler(this.BtnUpdateProduct_Click);
			// 
			// txtProductSKU
			// 
			this.txtProductSKU.Location = new System.Drawing.Point(242, 234);
			this.txtProductSKU.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtProductSKU.Name = "txtProductSKU";
			this.txtProductSKU.Size = new System.Drawing.Size(182, 31);
			this.txtProductSKU.TabIndex = 26;
			// 
			// cbxProductCategory
			// 
			this.cbxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxProductCategory.FormattingEnabled = true;
			this.cbxProductCategory.Location = new System.Drawing.Point(242, 151);
			this.cbxProductCategory.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.cbxProductCategory.Name = "cbxProductCategory";
			this.cbxProductCategory.Size = new System.Drawing.Size(182, 33);
			this.cbxProductCategory.TabIndex = 25;
			this.cbxProductCategory.SelectedIndexChanged += new System.EventHandler(this.CbxProductCategory_SelectedIndexChanged);
			// 
			// cbxGameRating
			// 
			this.cbxGameRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxGameRating.Enabled = false;
			this.cbxGameRating.FormattingEnabled = true;
			this.cbxGameRating.Location = new System.Drawing.Point(242, 194);
			this.cbxGameRating.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.cbxGameRating.Name = "cbxGameRating";
			this.cbxGameRating.Size = new System.Drawing.Size(182, 33);
			this.cbxGameRating.TabIndex = 24;
			// 
			// txtProductDesc
			// 
			this.txtProductDesc.Location = new System.Drawing.Point(242, 111);
			this.txtProductDesc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtProductDesc.Name = "txtProductDesc";
			this.txtProductDesc.Size = new System.Drawing.Size(182, 31);
			this.txtProductDesc.TabIndex = 23;
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(242, 71);
			this.txtProductPrice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(182, 31);
			this.txtProductPrice.TabIndex = 22;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(242, 31);
			this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(182, 31);
			this.txtProductName.TabIndex = 21;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(189, 238);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 25);
			this.label6.TabIndex = 20;
			this.label6.Text = "SKU:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(148, 155);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "Category:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 198);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(206, 25);
			this.label4.TabIndex = 18;
			this.label4.Text = "Rating (Only for Games):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(128, 115);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 25);
			this.label3.TabIndex = 17;
			this.label3.Text = "Description:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(182, 75);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 25);
			this.label2.TabIndex = 16;
			this.label2.Text = "Price:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(172, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 25);
			this.label1.TabIndex = 15;
			this.label1.Text = "Name:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtProductSKU);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxProductCategory);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbxGameRating);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtProductDesc);
			this.groupBox1.Controls.Add(this.txtProductName);
			this.groupBox1.Controls.Add(this.txtProductPrice);
			this.groupBox1.Location = new System.Drawing.Point(14, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(466, 296);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			// 
			// FrmUpdateProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 346);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnReturnHome);
			this.Controls.Add(this.btnClearForm);
			this.Controls.Add(this.btnUpdateProduct);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FrmUpdateProduct";
			this.Text = "Update Product";
			this.Load += new System.EventHandler(this.FrmUpdateProduct_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturnHome;
        private Button btnClearForm;
        private Button btnUpdateProduct;
        private TextBox txtProductSKU;
        private ComboBox cbxProductCategory;
        private ComboBox cbxGameRating;
        private TextBox txtProductDesc;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
    }
}