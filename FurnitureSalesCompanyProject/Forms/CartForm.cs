using FurnitureSalesCompanyProject.Controllers;
using FurnitureSalesCompanyProject.Models;
using FurnitureSalesCompanyProject.StaticData;
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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }
        public delegate void ResetCart(int count);
        public event ResetCart Click_btnResetCart;
        private void CartForm_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (SaleStatic.Sales != null && lblTotalCost.Text != "0")
            {
                if (MessageBox.Show("Подтвердите покупку", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Contract contract = new Contract();
                    contract.RegistrationDate = DateTime.Now.Date;
                    ContractController controller = new ContractController();
                    if (controller.Post(contract, SaleStatic.Sales))
                    {
                        SaleStatic.Sales = new List<Sale>();
                        MessageBox.Show("Продукт куплен");
                        Click_btnResetCart.Invoke(0);
                        SetData();
                    }
                }
            }
        }

        private void btnResetCart_Click(object sender, EventArgs e)
        {
            SaleStatic.Sales = new List<Sale>();
            Click_btnResetCart.Invoke(0);
            SetData();
        }
        private void SetData()
        {
            if (SaleStatic.Sales != null)
            {
                var sale = SaleStatic.Sales.Select(s => new
                { Name = s.Furniture.Category.Name, Model = s.Furniture.Model, Description = s.Furniture.Specifications, Quantity = s.Quantity, Price = s.Furniture.Cost}).ToList();
                dgvCart.DataSource = sale;
                dgvCart.Columns["Name"].HeaderText = "Наименование";
                dgvCart.Columns["Description"].HeaderText = "Описание";
                dgvCart.Columns["Quantity"].HeaderText = "Количество";
                dgvCart.Columns["Price"].HeaderText = "Цена";
                double total = 0;
                foreach (var tmp in sale)
                {
                    total += tmp.Price * tmp.Quantity;
                }
                lblTotalCost.Text = total.ToString();
            }
            else
            {
                var sale = new { Name = "", Descriotion = "", Quantit = 0, Price = 0 };
                dgvCart.DataSource = sale;
                lblTotalCost.Text = "0";
            }
        }
       
    }
}
