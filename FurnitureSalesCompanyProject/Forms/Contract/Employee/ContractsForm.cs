using FurnitureSalesCompanyProject.Controllers;
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
    public partial class ContractsForm : Form
    {
        private bool isApproved = false;
        private List<Contract> currentContracts = new List<Contract>();
        public ContractsForm()
        {
            InitializeComponent();
        }
        private void ContractsForm_Load(object sender, EventArgs e)
        {
            GetContractsFromController();
            SetContracts_dgvContracts();
            Setting_dgvContracts();
        }

        private void btnChangeIsApproved_Click(object sender, EventArgs e)
        {
            isApproved = !isApproved;

            if (isApproved == false)
            {
                btnChangeIsApproved.Text = "Показать подтвержденные";
            }
            else
            {
                btnChangeIsApproved.Text = "Показать не подтвержденные";
            }
            SetContracts_dgvContracts();
        }

        private void GetContractsFromController()
        {
            ContractController contractController = new ContractController();
            currentContracts = contractController.GetAll();
        }
        private void SetContracts_dgvContracts()
        {
            var contractsIsApprovedTrue = new List<Contract>();
            if (isApproved == true)
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
        }
        private void Setting_dgvContracts()
        {
            dgvContracts.Columns["Number"].HeaderText = "Номер заказа";
            dgvContracts.Columns["RegistrationDate"].HeaderText = "Дата регистрации";
            dgvContracts.Columns["DateOfExecution"].HeaderText = "Дата исполнения";
            dgvContracts.Columns["IsApproved"].Visible = false;
            dgvContracts.Columns["Customer"].Visible = false;
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = (int)dgvContracts.Rows[e.RowIndex].Cells[0].Value;
            var contract = currentContracts.Where(c => c.Number == num).FirstOrDefault();
            ContractDetails contractDetails = new ContractDetails(contract);
            contractDetails.ShowDialog();
            if (contractDetails.DialogResult == DialogResult.OK)
            {
                GetContractsFromController();
                SetContracts_dgvContracts();
            }
        }
    }
}
