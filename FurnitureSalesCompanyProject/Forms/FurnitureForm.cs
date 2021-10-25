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
    public partial class FurnitureForm : Form
    {
        FurnitureContext db;
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
            //FurnitureController controller = new FurnitureController();
            //var fur = controller.GetFurnitures();

            db = new FurnitureContext();
            var furnitures = db.FurnitureNames
                .SelectMany(f => f.Furnituries, (furname, fur) => new { furname, fur })
                .Select(f => new { Id = f.fur.Id, Name = f.furname.Name, Model = f.fur.Model, Specifications = f.fur.Specifications, Cost = f.fur.Cost })
                .ToList();
            dgvFurnitures.DataSource = furnitures;
            dgvFurnitures.Columns["Id"].Visible = false;
            dgvFurnitures.Columns["Name"].HeaderText = "Наименование";
            dgvFurnitures.Columns["Model"].HeaderText = "Модель";
            dgvFurnitures.Columns["Specifications"].HeaderText = "Характеристики";
            dgvFurnitures.Columns["Cost"].HeaderText = "Цена";
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.ShowDialog();
        }

        private void dgvFurnitures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            db = new FurnitureContext();
            int id = int.Parse(dgvFurnitures.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dgvFurnitures.Rows[e.RowIndex].Cells[1].Value.ToString();
            var currentFurniture = db.Furnitures.FirstOrDefault(f => f.Id == id);
            currentFurniture.FurnitureName = new FurnitureName() {Name = name };

            FurnitureDetails furnitureDetails = new FurnitureDetails(currentFurniture);
            furnitureDetails.ShowDialog();
        }
    }
}
