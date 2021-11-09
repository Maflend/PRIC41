using FurnitureSalesCompanyProject.Controllers;
using FurnitureSalesCompanyProject.DTO;
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
    public partial class ContractDetails : Form
    {
        private List<SaleWithFurnitureForDGVDto> currentSalesDto = new List<SaleWithFurnitureForDGVDto>();
        private Contract currentContract;
        private Customer currentCustomer;
        public ContractDetails()
        {
            InitializeComponent();
        }
        public ContractDetails(Contract contract)
        {
            InitializeComponent();
            currentContract = contract;
            dateTimePicker1.MinDate = currentContract.RegistrationDate;
            if(currentContract.IsApproved == true)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Value = currentContract.DateOfExecution;
                btnToApprove.Visible = false;
            }
        }
        private void ContractDetails_Load(object sender, EventArgs e)
        {
            GetSalesFromController(currentContract.Number);
            SetData_dgvSalesWithFurniture();
            Settings_dgvSalesWithFurniture();
            
            SetDataInTextBoxes();

        }
        private void GetSalesFromController(int number)
        {
            SaleController saleController = new SaleController();
            currentSalesDto = saleController.GetSalesByContractNumber(number);
        }
        private void SetData_dgvSalesWithFurniture()
        {
            if (currentSalesDto != null)
            {
                dgvSalesWithFurniture.DataSource = currentSalesDto;
            }
            else
                dgvSalesWithFurniture.DataSource = new List<SaleWithFurnitureForDGVDto>();
        }
        private void Settings_dgvSalesWithFurniture()
        {
            dgvSalesWithFurniture.Columns["Name"].HeaderText = "Наименование";
            dgvSalesWithFurniture.Columns["Model"].HeaderText = "Модель";
            dgvSalesWithFurniture.Columns["Specifications"].HeaderText = "Спецификация";
            dgvSalesWithFurniture.Columns["Cost"].HeaderText = "Цена";
            dgvSalesWithFurniture.Columns["Quantity"].HeaderText = "Кол-во";
        }
        private void SetDataInTextBoxes()
        {
            FurnitureContext db = new FurnitureContext();
            currentCustomer = db.Contracts.Where(c => c.Number == currentContract.Number).Select(c => c.Customer).FirstOrDefault();
            tbCustomerName.Text = currentCustomer.Name;
            tbNumber.Text = currentContract.Number.ToString();
            tbRegistrationDate.Text = currentContract.RegistrationDate.ToString();
        }
        private void btnToApprove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Вы точно подтверждаете этот договор с датой исполнения: {dateTimePicker1.Text}?", "Подтвердите одобрение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FurnitureContext db = new FurnitureContext();
                var c = db.Contracts.Where(c => c.Number == currentContract.Number).FirstOrDefault();
                c.IsApproved = true;
                c.DateOfExecution = dateTimePicker1.Value;
                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnShowCustomerDetails_Click(object sender, EventArgs e)
        {
            CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm(currentCustomer);
            customerDetailsForm.ShowDialog();
        }
    }
}
