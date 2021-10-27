
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
            this.btnOpenCustomersForm = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMenuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuTab
            // 
            this.panelMenuTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panelMenuTab.Controls.Add(this.btnLogout);
            this.panelMenuTab.Controls.Add(this.btnOpenFurnituresForm);
            this.panelMenuTab.Controls.Add(this.btnOpenCustomersForm);
            this.panelMenuTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuTab.Location = new System.Drawing.Point(0, 0);
            this.panelMenuTab.Name = "panelMenuTab";
            this.panelMenuTab.Size = new System.Drawing.Size(145, 480);
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
            this.btnOpenFurnituresForm.Size = new System.Drawing.Size(145, 54);
            this.btnOpenFurnituresForm.TabIndex = 1;
            this.btnOpenFurnituresForm.Text = "   Мебель";
            this.btnOpenFurnituresForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFurnituresForm.UseVisualStyleBackColor = false;
            this.btnOpenFurnituresForm.Click += new System.EventHandler(this.btnOpenFurnituresForm_Click);
            // 
            // btnOpenCustomersForm
            // 
            this.btnOpenCustomersForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenCustomersForm.FlatAppearance.BorderSize = 0;
            this.btnOpenCustomersForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCustomersForm.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenCustomersForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenCustomersForm.Location = new System.Drawing.Point(0, 0);
            this.btnOpenCustomersForm.Name = "btnOpenCustomersForm";
            this.btnOpenCustomersForm.Size = new System.Drawing.Size(145, 54);
            this.btnOpenCustomersForm.TabIndex = 0;
            this.btnOpenCustomersForm.Text = "   Клиенты";
            this.btnOpenCustomersForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCustomersForm.UseVisualStyleBackColor = false;
            this.btnOpenCustomersForm.Click += new System.EventHandler(this.btnOpenCustomersForm_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(145, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(700, 480);
            this.panelContent.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(0, 426);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 54);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "   Сменить пользователя";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(845, 480);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenuTab);
            this.MinimumSize = new System.Drawing.Size(861, 519);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenuTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuTab;
        private System.Windows.Forms.Button btnOpenCustomersForm;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnOpenFurnituresForm;
        private System.Windows.Forms.Button btnLogout;
    }
}