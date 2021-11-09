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
    public partial class CustomerDetailsForm : Form
    {
        private Customer currentCustomer;
        public CustomerDetailsForm()
        {
            InitializeComponent();
        }
        public CustomerDetailsForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
        }
        private void CustomerDetailsForm_Load(object sender, EventArgs e)
        {
            tbCode.Text = currentCustomer.Code.ToString();
            tbName.Text = currentCustomer.Name;
            tbAddress.Text = currentCustomer.Address;
            tbPhone.Text = currentCustomer.Phone;
        }
    }
}
