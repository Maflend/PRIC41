using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FurnitureSalesCompanyProject.Models;

namespace FurnitureSalesCompanyProject.Forms
{
    public partial class CustomersForm : Form
    {
        FurnitureContext db;
        public CustomersForm()
        {
            InitializeComponent();
            SetDataGrid();
            AddButtonColumns();
            dgvCustomers.BorderStyle = BorderStyle.None;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            
        }
        private void SetDataGrid()
        {
            db = new FurnitureContext();
            var customers = db.Customers.Select(c => c).ToList();
            dgvCustomers.DataSource = customers;
            dgvCustomers.Columns["Code"].HeaderText = "Код покупателя";
            dgvCustomers.Columns["Name"].HeaderText = "Название";
            dgvCustomers.Columns["Address"].HeaderText = "Адрес";
            dgvCustomers.Columns["Phone"].HeaderText = "Телефон";
            dgvCustomers.Columns["Login"].HeaderText = "Login";
            dgvCustomers.Columns["Password"].HeaderText = "Password";
            dgvCustomers.Columns["Login"].Visible = false;
            dgvCustomers.Columns["Password"].Visible = false;
            dgvCustomers.Columns["Discriminator"].Visible = false;
        }
        private void AddButtonColumns()
        {
            DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
            btnUpdate.Text = "Изменить";
            btnUpdate.Name = "Update";
            btnUpdate.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Text = "Удалить";
            btnDelete.Name = "Delete";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvCustomers.Columns.AddRange(btnUpdate, btnDelete);
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid code = Guid.Parse(dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString());
            if(dgvCustomers.Columns[e.ColumnIndex].Name == "Update")
            {
                UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(code);
                updateCustomerForm.ShowDialog();
                if (updateCustomerForm.DialogResult == DialogResult.OK)
                    SetDataGrid();
            }
            if(dgvCustomers.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(DeleteCustomer(code))
                {
                    MessageBox.Show("Успешно");
                }
            }
        }
        private bool DeleteCustomer(Guid code)
        {
            db = new FurnitureContext();
            var customer = db.Customers.FirstOrDefault(c => c.Code == code);
            if(customer != null)
            {
                db.Remove(customer);
                db.SaveChanges();
                SetDataGrid();
                return true;
            }
            return false;
        }
    }
}
