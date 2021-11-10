
namespace FurnitureSalesCompanyProject.Forms
{
    partial class ContractsHistoryForm
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
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.cbIsApproved = new System.Windows.Forms.CheckBox();
            this.btnUpdateData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContracts
            // 
            this.dgvContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(0, 36);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.RowTemplate.Height = 25;
            this.dgvContracts.Size = new System.Drawing.Size(684, 198);
            this.dgvContracts.TabIndex = 0;
            this.dgvContracts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContracts_CellClick);
            // 
            // dgvSales
            // 
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(0, 236);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.Size = new System.Drawing.Size(684, 203);
            this.dgvSales.TabIndex = 0;
            // 
            // cbIsApproved
            // 
            this.cbIsApproved.AutoSize = true;
            this.cbIsApproved.Location = new System.Drawing.Point(12, 3);
            this.cbIsApproved.Name = "cbIsApproved";
            this.cbIsApproved.Size = new System.Drawing.Size(148, 19);
            this.cbIsApproved.TabIndex = 1;
            this.cbIsApproved.Text = "Показать одобренные";
            this.cbIsApproved.UseVisualStyleBackColor = true;
            this.cbIsApproved.CheckedChanged += new System.EventHandler(this.cbIsApproved_CheckedChanged);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateData.Location = new System.Drawing.Point(492, 0);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(192, 30);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Text = "Обновить данные";
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // ContractsHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.cbIsApproved);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.dgvContracts);
            this.Name = "ContractsHistoryForm";
            this.Text = "История договоров";
            this.Load += new System.EventHandler(this.ContractsHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.CheckBox cbIsApproved;
        private System.Windows.Forms.Button btnUpdateData;
    }
}