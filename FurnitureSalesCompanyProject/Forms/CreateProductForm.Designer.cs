
namespace FurnitureSalesCompanyProject.Forms
{
    partial class CreateProductForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSpecifications = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFurnitureName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(138, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // tbSpecifications
            // 
            this.tbSpecifications.Location = new System.Drawing.Point(138, 103);
            this.tbSpecifications.Name = "tbSpecifications";
            this.tbSpecifications.Size = new System.Drawing.Size(100, 23);
            this.tbSpecifications.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Характеристики";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(138, 150);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 23);
            this.tbCost.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цена";
            // 
            // cbFurnitureName
            // 
            this.cbFurnitureName.FormattingEnabled = true;
            this.cbFurnitureName.Location = new System.Drawing.Point(138, 12);
            this.cbFurnitureName.Name = "cbFurnitureName";
            this.cbFurnitureName.Size = new System.Drawing.Size(121, 23);
            this.cbFurnitureName.TabIndex = 3;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 270);
            this.Controls.Add(this.cbFurnitureName);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpecifications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "CreateProductForm";
            this.Text = "CreateProductForm";
            this.Load += new System.EventHandler(this.CreateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSpecifications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFurnitureName;
    }
}