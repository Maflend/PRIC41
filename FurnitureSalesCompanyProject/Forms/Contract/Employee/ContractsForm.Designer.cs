namespace FurnitureSalesCompanyProject.Forms
{
    partial class ContractsForm
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
            this.btnChangeIsApproved = new System.Windows.Forms.Button();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeIsApproved
            // 
            this.btnChangeIsApproved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeIsApproved.Location = new System.Drawing.Point(490, 3);
            this.btnChangeIsApproved.Name = "btnChangeIsApproved";
            this.btnChangeIsApproved.Size = new System.Drawing.Size(193, 42);
            this.btnChangeIsApproved.TabIndex = 0;
            this.btnChangeIsApproved.Text = "Показать подтвержденные";
            this.btnChangeIsApproved.UseVisualStyleBackColor = true;
            this.btnChangeIsApproved.Click += new System.EventHandler(this.btnChangeIsApproved_Click);
            // 
            // dgvContracts
            // 
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvContracts.Location = new System.Drawing.Point(0, 51);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.RowTemplate.Height = 25;
            this.dgvContracts.Size = new System.Drawing.Size(684, 390);
            this.dgvContracts.TabIndex = 1;
            this.dgvContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellClick);
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.dgvContracts);
            this.Controls.Add(this.btnChangeIsApproved);
            this.Name = "ContractsForm";
            this.Text = "ContractsForm";
            this.Load += new System.EventHandler(this.ContractsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeIsApproved;
        private System.Windows.Forms.DataGridView dgvContracts;
    }
}