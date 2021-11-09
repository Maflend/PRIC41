namespace FurnitureSalesCompanyProject.Forms
{
    partial class ContractDetails
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
            this.btnToApprove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbRegistrationDate = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSalesWithFurniture = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnShowCustomerDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesWithFurniture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToApprove
            // 
            this.btnToApprove.Location = new System.Drawing.Point(305, 386);
            this.btnToApprove.Name = "btnToApprove";
            this.btnToApprove.Size = new System.Drawing.Size(155, 47);
            this.btnToApprove.TabIndex = 0;
            this.btnToApprove.Text = "Одобрить";
            this.btnToApprove.UseVisualStyleBackColor = true;
            this.btnToApprove.Click += new System.EventHandler(this.btnToApprove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(233, 6);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(227, 23);
            this.tbNumber.TabIndex = 3;
            // 
            // tbRegistrationDate
            // 
            this.tbRegistrationDate.Location = new System.Drawing.Point(233, 35);
            this.tbRegistrationDate.Name = "tbRegistrationDate";
            this.tbRegistrationDate.ReadOnly = true;
            this.tbRegistrationDate.Size = new System.Drawing.Size(227, 23);
            this.tbRegistrationDate.TabIndex = 3;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(241, 270);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.Size = new System.Drawing.Size(219, 23);
            this.tbCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заключения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата исполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Наименование заказчика";
            // 
            // dgvSalesWithFurniture
            // 
            this.dgvSalesWithFurniture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesWithFurniture.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSalesWithFurniture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesWithFurniture.Location = new System.Drawing.Point(2, 61);
            this.dgvSalesWithFurniture.Name = "dgvSalesWithFurniture";
            this.dgvSalesWithFurniture.ReadOnly = true;
            this.dgvSalesWithFurniture.RowTemplate.Height = 25;
            this.dgvSalesWithFurniture.Size = new System.Drawing.Size(458, 205);
            this.dgvSalesWithFurniture.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 349);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 9, 0, 0, 0, 0);
            // 
            // btnShowCustomerDetails
            // 
            this.btnShowCustomerDetails.Location = new System.Drawing.Point(357, 293);
            this.btnShowCustomerDetails.Name = "btnShowCustomerDetails";
            this.btnShowCustomerDetails.Size = new System.Drawing.Size(103, 23);
            this.btnShowCustomerDetails.TabIndex = 6;
            this.btnShowCustomerDetails.Text = "Подробнее";
            this.btnShowCustomerDetails.UseVisualStyleBackColor = true;
            this.btnShowCustomerDetails.Click += new System.EventHandler(this.btnShowCustomerDetails_Click);
            // 
            // ContractDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 435);
            this.Controls.Add(this.btnShowCustomerDetails);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvSalesWithFurniture);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbRegistrationDate);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToApprove);
            this.Name = "ContractDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContractDetails";
            this.Load += new System.EventHandler(this.ContractDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesWithFurniture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbRegistrationDate;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSalesWithFurniture;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnShowCustomerDetails;
    }
}