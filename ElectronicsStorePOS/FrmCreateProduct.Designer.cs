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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductSKU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProductCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGameRating = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnReturnHome = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.cbxStepTwo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(326, 178);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // txtProductSKU
            // 
            this.txtProductSKU.Location = new System.Drawing.Point(170, 140);
            this.txtProductSKU.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductSKU.Name = "txtProductSKU";
            this.txtProductSKU.Size = new System.Drawing.Size(128, 23);
            this.txtProductSKU.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rating (Only for Games):";
            // 
            // cbxProductCategory
            // 
            this.cbxProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductCategory.FormattingEnabled = true;
            this.cbxProductCategory.Location = new System.Drawing.Point(170, 91);
            this.cbxProductCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProductCategory.Name = "cbxProductCategory";
            this.cbxProductCategory.Size = new System.Drawing.Size(128, 23);
            this.cbxProductCategory.TabIndex = 25;
            this.cbxProductCategory.SelectedIndexChanged += new System.EventHandler(this.CbxProductCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Category:";
            // 
            // cbxGameRating
            // 
            this.cbxGameRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGameRating.Enabled = false;
            this.cbxGameRating.FormattingEnabled = true;
            this.cbxGameRating.Location = new System.Drawing.Point(170, 116);
            this.cbxGameRating.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGameRating.Name = "cbxGameRating";
            this.cbxGameRating.Size = new System.Drawing.Size(128, 23);
            this.cbxGameRating.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "SKU:";
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(170, 67);
            this.txtProductDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(128, 23);
            this.txtProductDesc.TabIndex = 23;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(170, 19);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(128, 23);
            this.txtProductName.TabIndex = 21;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(170, 43);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(128, 23);
            this.txtProductPrice.TabIndex = 22;
            // 
            // btnReturnHome
            // 
            this.btnReturnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnHome.Location = new System.Drawing.Point(383, 81);
            this.btnReturnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnHome.Name = "btnReturnHome";
            this.btnReturnHome.Size = new System.Drawing.Size(105, 40);
            this.btnReturnHome.TabIndex = 33;
            this.btnReturnHome.Text = "Return Home";
            this.btnReturnHome.UseVisualStyleBackColor = true;
            this.btnReturnHome.Click += new System.EventHandler(this.BtnReturnHome_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearForm.Location = new System.Drawing.Point(383, 140);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(105, 40);
            this.btnClearForm.TabIndex = 32;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.BtnClearForm_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.Location = new System.Drawing.Point(383, 22);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(105, 40);
            this.btnCreateProduct.TabIndex = 31;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.BtnCreateProduct_Click);
            // 
            // cbxStepTwo
            // 
            this.cbxStepTwo.AutoSize = true;
            this.cbxStepTwo.Enabled = false;
            this.cbxStepTwo.Location = new System.Drawing.Point(428, 186);
            this.cbxStepTwo.Name = "cbxStepTwo";
            this.cbxStepTwo.Size = new System.Drawing.Size(15, 14);
            this.cbxStepTwo.TabIndex = 35;
            this.cbxStepTwo.UseVisualStyleBackColor = true;
            this.cbxStepTwo.Visible = false;
            // 
            // FrmCreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 208);
            this.Controls.Add(this.cbxStepTwo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturnHome);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCreateProduct);
            this.Name = "FrmCreateProduct";
            this.Text = "Create a Product";
            this.Load += new System.EventHandler(this.FrmCreateProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtProductSKU;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxProductCategory;
        private Label label5;
        private ComboBox cbxGameRating;
        private Label label6;
        private TextBox txtProductDesc;
        private TextBox txtProductName;
        private TextBox txtProductPrice;
        private Button btnReturnHome;
        private Button btnClearForm;
        private Button btnCreateProduct;
        private CheckBox cbxStepTwo;
    }
}