﻿namespace ElectronicsStorePOS
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
            this.SuspendLayout();
            // 
            // btnOpenCreateProductForm
            // 
            this.btnOpenCreateProductForm.Location = new System.Drawing.Point(408, 124);
            this.btnOpenCreateProductForm.Name = "btnOpenCreateProductForm";
            this.btnOpenCreateProductForm.Size = new System.Drawing.Size(105, 40);
            this.btnOpenCreateProductForm.TabIndex = 0;
            this.btnOpenCreateProductForm.Text = "Create Product";
            this.btnOpenCreateProductForm.UseVisualStyleBackColor = true;
            this.btnOpenCreateProductForm.Click += new System.EventHandler(this.BtnOpenCreateProductForm_Click);
            // 
            // btnOpenUpdateProductForm
            // 
            this.btnOpenUpdateProductForm.Location = new System.Drawing.Point(408, 170);
            this.btnOpenUpdateProductForm.Name = "btnOpenUpdateProductForm";
            this.btnOpenUpdateProductForm.Size = new System.Drawing.Size(105, 40);
            this.btnOpenUpdateProductForm.TabIndex = 1;
            this.btnOpenUpdateProductForm.Text = "Update Product";
            this.btnOpenUpdateProductForm.UseVisualStyleBackColor = true;
            this.btnOpenUpdateProductForm.Click += new System.EventHandler(this.BtnOpenUpdateProductForm_Click);
            // 
            // FrmElectronicStorePOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenUpdateProductForm);
            this.Controls.Add(this.btnOpenCreateProductForm);
            this.Name = "FrmElectronicStorePOS";
            this.Text = "Electronic Store POS";
            this.ResumeLayout(false);

		}

        #endregion

        private Button btnOpenCreateProductForm;
        private Button btnOpenUpdateProductForm;
    }
}