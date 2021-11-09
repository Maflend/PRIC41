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
        private List<FurnitureForDGVDto> furnituresForDGVDtoFromController;
        private List<FurnitureForDGVDto> currentFurnituresForDGVDto;
        public FurnitureForm()
        {
            InitializeComponent();
            dgvFurnitures.BorderStyle = BorderStyle.None;
            if (CurrentUser.isCustomer == true)
            {
                btnCreateProduct.Visible = false;
            }
        }
        public delegate void FurnitureSaless(int count);
        public event FurnitureSaless FurnitureSold;


        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            GetData();
            SetDataInDGV();
            CurrentFurnituresForDGVDto_SetDefault();
            SetDataInComboBox();
        }
        private void SetDataInComboBox()
        {
            var names = new FurnitureController().GetCategories().Select(f => f.Name).ToList();
            names.Insert(0, "");
            comboBoxCategories.DataSource = names;
        }
        private void CurrentFurnituresForDGVDto_SetDefault()
        {
            currentFurnituresForDGVDto = furnituresForDGVDtoFromController;
        }
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
            if (createProductForm.DialogResult == DialogResult.Yes)
            {
                GetData();
                SetDataInDGV();
            }
        }
        private void dgvFurnitures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgvFurnitures.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dgvFurnitures.Rows[e.RowIndex].Cells[1].Value.ToString();
            FurnitureDetails furnitureDetails = new FurnitureDetails(id, name);
            furnitureDetails.ShowDialog();
            if (furnitureDetails.DialogResult == DialogResult.Yes)
            {
                FurnitureSold?.Invoke(SaleStatic.Sales.Count);
                GetData();
                SetDataInDGV();
                SetDataInComboBox();
            }
        }
        private void SetDataInDGV(List<FurnitureForDGVDto> furnitures)
        {
            dgvFurnitures.DataSource = furnitures;
            DisplaySetting();
        }
        private void SetDataInDGV()
        {
            dgvFurnitures.DataSource = furnituresForDGVDtoFromController;
            DisplaySetting();
        }
        private void GetData()
        {
            furnitureController = new FurnitureController();
            furnituresForDGVDtoFromController = furnitureController.GetAllFurnitureForDGVDto();
        }
        private void DisplaySetting()
        {
            dgvFurnitures.Columns["Id"].Visible = false;
            dgvFurnitures.Columns["Name"].HeaderText = "Наименование";
            dgvFurnitures.Columns["Model"].HeaderText = "Модель";
            dgvFurnitures.Columns["Specifications"].HeaderText = "Характеристики";
            dgvFurnitures.Columns["Cost"].HeaderText = "Цена";
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var furnitures = currentFurnituresForDGVDto.Where(f=>f.Model.StartsWith(tbSearch.Text)).ToList();
            SetDataInDGV(furnitures);
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            int index = comboBoxCategories.SelectedIndex;
            var item = comboBoxCategories.SelectedItem;
            if (index == 0)
            {
                CurrentFurnituresForDGVDto_SetDefault();
                SetDataInDGV();
            }
            else
            {
                var furnituresByName = furnituresForDGVDtoFromController.Where(f => f.Name == (string)item).ToList();
                currentFurnituresForDGVDto = furnituresByName;
                SetDataInDGV(currentFurnituresForDGVDto);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
            comboBoxCategories.SelectedIndex = 0;
            GetData();
            CurrentFurnituresForDGVDto_SetDefault();
            SetDataInDGV();
        }
    }

   
}
