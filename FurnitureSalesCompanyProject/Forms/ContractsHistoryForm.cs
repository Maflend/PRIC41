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
    public partial class ContractsHistoryForm : Form
    {
        public ContractsHistoryForm()
        {
            InitializeComponent();

        }

        private void ContractsHistoryForm_Load(object sender, EventArgs e)
        {
            ContractController controller = new ContractController();
            var orders = controller.GetAll();
            if (orders != null)
            {
                dgvContracts.DataSource = orders;
                dgvContracts.Columns["Number"].HeaderText = "Номер заказа";
                dgvContracts.Columns["RegistrationDate"].HeaderText = "Дата регистрации";
                dgvContracts.Columns["DateOfExecution"].HeaderText = "Дата исполнения";
                dgvContracts.Columns["Customer"].Visible = false;
            }
        }

        private void dgvContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Contract contract = new Contract();
                contract.Number = (int)dgvContracts.Rows[e.RowIndex].Cells[0].Value;
                contract.RegistrationDate = Convert.ToDateTime(dgvContracts.Rows[e.RowIndex].Cells[1].Value.ToString());
                contract.DateOfExecution = Convert.ToDateTime(dgvContracts.Rows[e.RowIndex].Cells[2].Value.ToString());
                FurnitureContext db = new FurnitureContext();
                var salesFurniture = db.Sales.Where(s => s.Contract.Number == contract.Number).Select(s => new {Name = s.Furniture.Category.Name, s.Furniture.Model, s.Furniture.Specifications, s.Furniture.Cost, s.Quantity }).ToList();
                if (salesFurniture != null)
                {

                    dgvSales.DataSource = salesFurniture;
                    dgvSales.Columns["Name"].HeaderText = "Наименование";
                    dgvSales.Columns["Model"].HeaderText = "Модель";
                    dgvSales.Columns["Specifications"].HeaderText = "Спецификация";
                    dgvSales.Columns["Cost"].HeaderText = "Цена";
                    dgvSales.Columns["Quantity"].HeaderText = "Количество";
                }
            }
        }
    }
}
