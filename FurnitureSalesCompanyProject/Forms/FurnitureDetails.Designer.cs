
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
            this.lblFurnitureName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecifications = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFurnitureName
            // 
            this.lblFurnitureName.AutoSize = true;
            this.lblFurnitureName.Location = new System.Drawing.Point(121, 28);
            this.lblFurnitureName.Name = "lblFurnitureName";
            this.lblFurnitureName.Size = new System.Drawing.Size(38, 15);
            this.lblFurnitureName.TabIndex = 0;
            this.lblFurnitureName.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(121, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // lblSpecifications
            // 
            this.lblSpecifications.AutoSize = true;
            this.lblSpecifications.Location = new System.Drawing.Point(121, 86);
            this.lblSpecifications.Name = "lblSpecifications";
            this.lblSpecifications.Size = new System.Drawing.Size(38, 15);
            this.lblSpecifications.TabIndex = 0;
            this.lblSpecifications.Text = "label1";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(121, 110);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(38, 15);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "label1";
            // 
            // FurnitureDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 305);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblSpecifications);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFurnitureName);
            this.Name = "FurnitureDetails";
            this.Text = "FurnitureDetails";
            this.Load += new System.EventHandler(this.FurnitureDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFurnitureName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecifications;
        private System.Windows.Forms.Label lblCost;
    }
}