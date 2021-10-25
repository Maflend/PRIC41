
namespace FurnitureSalesCompanyProject.Forms
{
    partial class MainForm
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
            this.panelMenuTab = new System.Windows.Forms.Panel();
            this.btnOpenFurnituresForm = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuTab
            // 
            this.panelMenuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.panelMenuTab.Controls.Add(this.btnOpenFurnituresForm);
            this.panelMenuTab.Controls.Add(this.btnCustomers);
            this.panelMenuTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuTab.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTab.Name = "panelMenuTab";
            this.panelMenuTab.Size = new System.Drawing.Size(213, 487);
            this.panelMenuTab.TabIndex = 0;
            // 
            // btnOpenFurnituresForm
            // 
            this.btnOpenFurnituresForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFurnituresForm.FlatAppearance.BorderSize = 0;
            this.btnOpenFurnituresForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFurnituresForm.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenFurnituresForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenFurnituresForm.Location = new System.Drawing.Point(0, 54);
            this.btnOpenFurnituresForm.Name = "btnOpenFurnituresForm";
            this.btnOpenFurnituresForm.Size = new System.Drawing.Size(213, 54);
            this.btnOpenFurnituresForm.TabIndex = 1;
            this.btnOpenFurnituresForm.Text = "   Мебель";
            this.btnOpenFurnituresForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFurnituresForm.UseVisualStyleBackColor = false;
            this.btnOpenFurnituresForm.Click += new System.EventHandler(this.btnOpenFurnituresForm_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(213, 54);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "   Клиенты";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(213, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(582, 487);
            this.panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(795, 487);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenuTab);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenuTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuTab;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnOpenFurnituresForm;
    }
}