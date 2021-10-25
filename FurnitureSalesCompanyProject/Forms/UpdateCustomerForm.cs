using FurnitureSalesCompanyProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureSalesCompanyProject.Forms
{
    public partial class UpdateCustomerForm : Form
    {
        private Customer currentCustomer;
        private FurnitureContext db;
        public UpdateCustomerForm(Guid code)
        {
            InitializeComponent();
            Customer customer = GetCustomer(code);
            if (customer != null)
                currentCustomer = customer;
            else
                currentCustomer = new Customer();
        }
        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            SetData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтвердите сохранение", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                currentCustomer.Name = tbName.Text;
                currentCustomer.Address = tbAddress.Text;
                currentCustomer.Phone = tbPhone.Text;
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }    
            else
                SetData();
        }
        private Customer GetCustomer(Guid code)
        {
            db = new FurnitureContext();
            var customer = db.Customers.FirstOrDefault(c => c.Code == code);
            return customer;
        }
        private void SetData()
        {
            tbCode.Text = currentCustomer.Code.ToString();
            tbName.Text = currentCustomer.Name;
            tbAddress.Text = currentCustomer.Address;
            tbPhone.Text = currentCustomer.Phone;
        }

        private void UpdateCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
