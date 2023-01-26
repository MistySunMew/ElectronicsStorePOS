namespace ElectronicsStorePOS
{
    partial class FrmCreateProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.cbxGameRating = new System.Windows.Forms.ComboBox();
            this.cbxProductCategory = new System.Windows.Forms.ComboBox();
            this.txtProductSKU = new System.Windows.Forms.TextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating (Only for Games)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "SKU";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(237, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 31);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(237, 62);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(150, 31);
            this.txtProductPrice.TabIndex = 7;
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(237, 105);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(150, 31);
            this.txtProductDesc.TabIndex = 8;
            // 
            // cbxGameRating
            // 
            this.cbxGameRating.FormattingEnabled = true;
            this.cbxGameRating.Location = new System.Drawing.Point(237, 148);
            this.cbxGameRating.Name = "cbxGameRating";
            this.cbxGameRating.Size = new System.Drawing.Size(182, 33);
            this.cbxGameRating.TabIndex = 9;
            // 
            // cbxProductCategory
            // 
            this.cbxProductCategory.FormattingEnabled = true;
            this.cbxProductCategory.Location = new System.Drawing.Point(237, 191);
            this.cbxProductCategory.Name = "cbxProductCategory";
            this.cbxProductCategory.Size = new System.Drawing.Size(182, 33);
            this.cbxProductCategory.TabIndex = 10;
            // 
            // txtProductSKU
            // 
            this.txtProductSKU.Location = new System.Drawing.Point(237, 250);
            this.txtProductSKU.Name = "txtProductSKU";
            this.txtProductSKU.Size = new System.Drawing.Size(150, 31);
            this.txtProductSKU.TabIndex = 11;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(33, 306);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(198, 74);
            this.btnCreateProduct.TabIndex = 12;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(237, 306);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(198, 74);
            this.btnClearForm.TabIndex = 13;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.Location = new System.Drawing.Point(417, 20);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(198, 74);
            this.btnReturnHome.TabIndex = 14;
            this.btnReturnHome.Text = "Return Home";
            this.btnReturnHome.UseVisualStyleBackColor = true;
            this.btnReturnHome.Click += new System.EventHandler(this.btnReturnHome_Click);
            // 
            // FrmCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 404);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.txtProductSKU);
            this.Controls.Add(this.cbxProductCategory);
            this.Controls.Add(this.cbxGameRating);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCreateProduct";
            this.Text = "Create a Product";
            this.Load += new System.EventHandler(this.FrmCreateProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtProductName;
        private TextBox txtProductPrice;
        private TextBox txtProductDesc;
        private ComboBox cbxGameRating;
        private ComboBox cbxProductCategory;
        private TextBox txtProductSKU;
        private Button btnCreateProduct;
        private Button btnClearForm;
        private Button btnReturnHome;
    }
}