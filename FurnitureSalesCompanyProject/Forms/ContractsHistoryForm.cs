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
    public partial class ContractsHistoryForm : Form
    {
        private List<Contract> currentContracts;
        private List<SaleWithFurnitureForDGVDto> currentSalesDto;
        public ContractsHistoryForm()
        {
            InitializeComponent();
        }

        private void ContractsHistoryForm_Load(object sender, EventArgs e)
        {
            currentContracts = new List<Contract>();
            currentContracts = GetContractsFromController();
            SetData_dgvContracts();
        }
        private void cbIsApproved_CheckedChanged(object sender, EventArgs e)
        {
            SetData_dgvContracts();
        }
        private List<Contract> GetContractsFromController()
        {
            ContractController controller = new ContractController();
            var contracts = controller.GetAll();
            return contracts;
        }
        private void SetData_dgvContracts()
        {
            if (currentContracts is null)
                dgvContracts.DataSource = new List<Contract>();

            var contractsIsApprovedTrue = new List<Contract>();
            if (cbIsApproved.Checked == true)
            {
                contractsIsApprovedTrue = currentContracts.Where(c => c.IsApproved == true).ToList();
            }
            else
            {
                contractsIsApprovedTrue = currentContracts.Where(c => c.IsApproved == false).ToList();
            }
            
            if (contractsIsApprovedTrue != null)
            {
                dgvContracts.DataSource = contractsIsApprovedTrue;
            }
            Settings_dgvContracts();
        }
        private void Settings_dgvContracts()
        {
            dgvContracts.Columns["Number"].HeaderText = "Номер заказа";
            dgvContracts.Columns["RegistrationDate"].HeaderText = "Дата регистрации";
            dgvContracts.Columns["DateOfExecution"].HeaderText = "Дата исполнения";
            dgvContracts.Columns["IsApproved"].Visible = false;
            dgvContracts.Columns["Customer"].Visible = false;
        }
        private void GetSalesFromController(int number)
        {
            SaleController saleController = new SaleController();
            currentSalesDto = saleController.GetSalesByContractNumber(number);
        }
        private void SetData_dgvSales()
        {
            if (currentSalesDto != null)
            {
                dgvSales.DataSource = currentSalesDto;
            }
        }
        private void Settings_dgvSales()
        {
            dgvSales.Columns["Name"].HeaderText = "Наименование";
            dgvSales.Columns["Model"].HeaderText = "Модель";
            dgvSales.Columns["Specifications"].HeaderText = "Спецификация";
            dgvSales.Columns["Cost"].HeaderText = "Цена";
            dgvSales.Columns["Quantity"].HeaderText = "Количество";
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var number = (int)dgvContracts.Rows[e.RowIndex].Cells[0].Value;
                GetSalesFromController(number);
                SetData_dgvSales();
                Settings_dgvSales();
            }

        }

    }

    
}
