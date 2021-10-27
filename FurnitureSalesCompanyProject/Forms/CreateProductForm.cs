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
    public partial class CreateProductForm : Form
    {
        FurnitureContext db;
        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
            db = new FurnitureContext();
            var furnitureName = db.FurnitureNames.Select(n => n.Name).ToList();
            
            cbFurnitureName.DataSource = furnitureName;
            cbFurnitureName.SelectedItem = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateFurniture();
        }
        private void CreateFurniture()  
            // Добавить отдельый текстбокс, и если пользователь хочет новую категорию моделей то пусть вписывает
        {
            FurnitureFurnitureForDGVDto furniture = new FurnitureFurnitureForDGVDto();
            furniture.Model = tbName.Text;
            furniture.Specifications = tbSpecifications.Text;
            furniture.Cost = int.Parse(tbCost.Text);
            

            if (!db.FurnitureNames.Any(f=>f.Name == cbFurnitureName.SelectedItem.ToString()))
            {
                FurnitureName furnitureName = new FurnitureName();
                furnitureName.Name = cbFurnitureName.SelectedItem.ToString();
                db.FurnitureNames.Add(furnitureName);
            }
            var furName = db.FurnitureNames.FirstOrDefault(f => f.Name == cbFurnitureName.SelectedItem.ToString());

            furniture.FurnitureName = furName;
            db.Furnitures.Add(furniture);
            db.SaveChanges();
        }
    }
}
