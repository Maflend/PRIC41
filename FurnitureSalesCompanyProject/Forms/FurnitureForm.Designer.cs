
namespace FurnitureSalesCompanyProject.Forms
{
    partial class FurnitureForm
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
            this.dgvFurnitures = new System.Windows.Forms.DataGridView();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnitures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFurnitures
            // 
            this.dgvFurnitures.AllowUserToAddRows = false;
            this.dgvFurnitures.AllowUserToDeleteRows = false;
            this.dgvFurnitures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFurnitures.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFurnitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFurnitures.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFurnitures.Location = new System.Drawing.Point(0, 0);
            this.dgvFurnitures.Name = "dgvFurnitures";
            this.dgvFurnitures.ReadOnly = true;
            this.dgvFurnitures.RowTemplate.Height = 25;
            this.dgvFurnitures.Size = new System.Drawing.Size(800, 332);
            this.dgvFurnitures.TabIndex = 0;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(656, 395);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(132, 43);
            this.btnCreateProduct.TabIndex = 1;
            this.btnCreateProduct.Text = "Добавить";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // FurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.dgvFurnitures);
            this.Name = "FurnitureForm";
            this.Text = "FurnitureForm";
            this.Load += new System.EventHandler(this.FurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnitures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFurnitures;
        private System.Windows.Forms.Button btnCreateProduct;
    }
}