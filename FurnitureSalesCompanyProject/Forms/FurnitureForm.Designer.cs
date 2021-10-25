
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
            this.panelFurnituriesMenu = new System.Windows.Forms.Panel();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnitures)).BeginInit();
            this.panelFurnituriesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFurnitures
            // 
            this.dgvFurnitures.AllowUserToAddRows = false;
            this.dgvFurnitures.AllowUserToDeleteRows = false;
            this.dgvFurnitures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFurnitures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFurnitures.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFurnitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFurnitures.Location = new System.Drawing.Point(0, 107);
            this.dgvFurnitures.Name = "dgvFurnitures";
            this.dgvFurnitures.ReadOnly = true;
            this.dgvFurnitures.RowTemplate.Height = 25;
            this.dgvFurnitures.Size = new System.Drawing.Size(684, 335);
            this.dgvFurnitures.TabIndex = 0;
            this.dgvFurnitures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFurnitures_CellDoubleClick);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProduct.FlatAppearance.BorderSize = 3;
            this.btnCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateProduct.Location = new System.Drawing.Point(555, 17);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(117, 38);
            this.btnCreateProduct.TabIndex = 1;
            this.btnCreateProduct.Text = "Добавить мебель";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // panelFurnituriesMenu
            // 
            this.panelFurnituriesMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFurnituriesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panelFurnituriesMenu.Controls.Add(this.comboBoxCategories);
            this.panelFurnituriesMenu.Controls.Add(this.tbSearch);
            this.panelFurnituriesMenu.Controls.Add(this.label2);
            this.panelFurnituriesMenu.Controls.Add(this.label1);
            this.panelFurnituriesMenu.Controls.Add(this.btnReset);
            this.panelFurnituriesMenu.Controls.Add(this.btnCreateProduct);
            this.panelFurnituriesMenu.Location = new System.Drawing.Point(0, 0);
            this.panelFurnituriesMenu.Name = "panelFurnituriesMenu";
            this.panelFurnituriesMenu.Size = new System.Drawing.Size(684, 101);
            this.panelFurnituriesMenu.TabIndex = 2;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(205, 65);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(145, 23);
            this.comboBoxCategories.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(205, 26);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(268, 23);
            this.tbSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите название модели";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите категорию мебели";
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 3;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(356, 59);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 32);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // FurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.panelFurnituriesMenu);
            this.Controls.Add(this.dgvFurnitures);
            this.Name = "FurnitureForm";
            this.Text = "FurnitureForm";
            this.Load += new System.EventHandler(this.FurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFurnitures)).EndInit();
            this.panelFurnituriesMenu.ResumeLayout(false);
            this.panelFurnituriesMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFurnitures;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Panel panelFurnituriesMenu;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
    }
}