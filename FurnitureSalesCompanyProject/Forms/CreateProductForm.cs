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
    public partial class CreateProductForm : Form
    {
        private string newCategory;
        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
            FurnitureController FurnitureController = new FurnitureController();
            var contracts = FurnitureController.GetCategories();
            var Category = contracts.Select(c => c.Name).ToList();
            Category.Insert(0, "");

            cbCategory.DataSource = Category;
            cbCategory.SelectedItem = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateFurniture();
            this.DialogResult = DialogResult.Yes;
        }
        private void CreateFurniture()
        {
           
            FurnitureController furnitureController = new FurnitureController();
            var currentFurniture = GetFurniture();
            if (GetFurniture() !=null)
            {
                if (cbCategory.SelectedIndex == -1)
                {
                    Category Category = new Category();
                    Category.Name = newCategory;
                    var isDone = furnitureController.AddCategory(Category);
                    if (!isDone)
                    {
                        MessageBox.Show("Не удалось добавить новую категорию.");
                        this.Close();
                    }
                }
                var category = furnitureController.GetCategoryByName(newCategory);
                currentFurniture.Category = category;
                furnitureController.AddFirniture(currentFurniture);
            }
                
        }
        private Furniture GetFurniture()
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text) && !string.IsNullOrWhiteSpace(tbSpecifications.Text))
            {
                Furniture furniture = new Furniture();
                furniture.Model = tbName.Text;
                furniture.Specifications = tbSpecifications.Text;
                if (int.TryParse(tbCost.Text, out int cost))
                    furniture.Cost = cost;
                return furniture;
            }
            else
            {
                MessageBox.Show("Неккоректно заполнены поля");
                return null;
            }
            
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex != 0)
            {
                cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
                cbCategory.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void cbCategory_TextChanged(object sender, EventArgs e)
        {
            newCategory = ((ComboBox)sender).Text;
        }
    }
}
