
namespace FurnitureSalesCompanyProject.Forms
{
    partial class FurnitureDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbSpecifications = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(122, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuy.Location = new System.Drawing.Point(122, 261);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(106, 32);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Купить";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(14, 12);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(207, 23);
            this.tbCategory.TabIndex = 2;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(14, 41);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(207, 23);
            this.tbModel.TabIndex = 2;
            // 
            // tbSpecifications
            // 
            this.tbSpecifications.Location = new System.Drawing.Point(14, 70);
            this.tbSpecifications.Name = "tbSpecifications";
            this.tbSpecifications.Size = new System.Drawing.Size(207, 23);
            this.tbSpecifications.TabIndex = 2;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(14, 99);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(207, 23);
            this.tbCost.TabIndex = 2;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(121, 142);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(100, 23);
            this.tbQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 145);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(100, 15);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Введите кол-во : ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(7, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(122, 205);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(49, 15);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(7, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FurnitureDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 299);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbSpecifications);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuantity);
            this.MaximumSize = new System.Drawing.Size(254, 338);
            this.MinimumSize = new System.Drawing.Size(254, 338);
            this.Name = "FurnitureDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Детали мебели";
            this.Load += new System.EventHandler(this.FurnitureDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbSpecifications;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnDelete;
    }
}