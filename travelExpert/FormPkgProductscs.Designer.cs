﻿
namespace travelExpert
{
    partial class FormPkgProductscs
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
            this.listBoxPkgProd = new System.Windows.Forms.ListBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.listBoxSelectSupp = new System.Windows.Forms.ListBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPkgProd
            // 
            this.listBoxPkgProd.FormattingEnabled = true;
            this.listBoxPkgProd.ItemHeight = 18;
            this.listBoxPkgProd.Location = new System.Drawing.Point(63, 19);
            this.listBoxPkgProd.Name = "listBoxPkgProd";
            this.listBoxPkgProd.Size = new System.Drawing.Size(664, 130);
            this.listBoxPkgProd.TabIndex = 0;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(78, 193);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(151, 26);
            this.comboBoxProducts.TabIndex = 1;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // listBoxSelectSupp
            // 
            this.listBoxSelectSupp.FormattingEnabled = true;
            this.listBoxSelectSupp.ItemHeight = 18;
            this.listBoxSelectSupp.Location = new System.Drawing.Point(382, 197);
            this.listBoxSelectSupp.Name = "listBoxSelectSupp";
            this.listBoxSelectSupp.Size = new System.Drawing.Size(345, 202);
            this.listBoxSelectSupp.TabIndex = 2;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(84, 257);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(145, 60);
            this.btnAddProd.TabIndex = 4;
            this.btnAddProd.Text = "Add Product/Supplier";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select supplier:";
            // 
            // FormPkgProductscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.listBoxSelectSupp);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.listBoxPkgProd);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormPkgProductscs";
            this.Text = "FormPkgProductscs";
            this.Load += new System.EventHandler(this.FormPkgProductscs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPkgProd;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ListBox listBoxSelectSupp;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}