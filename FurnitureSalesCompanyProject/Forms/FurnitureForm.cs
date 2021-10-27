using FurnitureSalesCompanyProject.Controllers;
using FurnitureSalesCompanyProject.DTO;
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
    public partial class FurnitureForm : Form
    {
        FurnitureController furnitureController;
        public FurnitureForm()
        {
            InitializeComponent();
            dgvFurnitures.BorderStyle = BorderStyle.None;
            if (CurrentUser.isCustomer == true)
            {
                btnCreateProduct.Visible = false;
            }
            
        }

        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            SetDataInDGV();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
        }

        private void dgvFurnitures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvFurnitures.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dgvFurnitures.Rows[e.RowIndex].Cells[1].Value.ToString();
            FurnitureDetails furnitureDetails = new FurnitureDetails(id, name);
            furnitureDetails.ShowDialog();
            if (furnitureDetails.DialogResult == DialogResult.Yes)
                SetDataInDGV();

        }
        private void SetDataInDGV()
        {
            furnitureController = new FurnitureController();
            var furnitures = furnitureController.GetAllFurnitureForDGVDto();
            dgvFurnitures.DataSource = furnitures;
            dgvFurnitures.Columns["Id"].Visible = false;
            dgvFurnitures.Columns["Name"].HeaderText = "Наименование";
            dgvFurnitures.Columns["Model"].HeaderText = "Модель";
            dgvFurnitures.Columns["Specifications"].HeaderText = "Характеристики";
            dgvFurnitures.Columns["Cost"].HeaderText = "Цена";
        }
    }

   
}
