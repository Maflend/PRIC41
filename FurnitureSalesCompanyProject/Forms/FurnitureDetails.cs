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
    public partial class FurnitureDetails : Form
    {
       
        private Furniture currentFurniture;
        private FurnitureController controller = new FurnitureController();
        private Size windowsSize;
        public FurnitureDetails(int id, string name)
        {
            InitializeComponent();
            if(CurrentUser.isCustomer == true)
            {
                tbCategory.ReadOnly = true;
                tbModel.ReadOnly = true;
                tbSpecifications.ReadOnly = true;
                tbCost.ReadOnly = true;
                btnCancel.Visible = false;
                btnSave.Visible = false;

                windowsSize = new Size(259, 340);
                this.MaximumSize = windowsSize;
                this.MinimumSize = windowsSize;
            }
            else
            {
                btnBuy.Visible = false;

                windowsSize = new Size(259, 296);
                this.MaximumSize = windowsSize;
                this.MinimumSize = windowsSize;
            }
            SetDataInUserControls(id, name);
            currentFurniture = ContextStatic.FurnitureContext.Furnitures.FirstOrDefault(f => f.Id == id);
        }

        private void FurnitureDetails_Load(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
            if (SaleStatic.Sales != null)
            {
                int tmp = SaleStatic.Sales.Where(s => s.Furniture.Id == currentFurniture.Id).Sum(s => s.Quantity);
                tbQuantity.Text = tmp.ToString();
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbQuantity.Text, out int quantity))
            {

                if (SaleStatic.Sales != null && SaleStatic.Sales.Any(s => s.Furniture.Id == currentFurniture.Id))
                {
                    for (int i = 0; i < SaleStatic.Sales.Count(); i++)
                    {
                        if (SaleStatic.Sales[i].Furniture.Id == currentFurniture.Id)
                        {
                            SaleStatic.Sales[i].Quantity = quantity;
                        }
                    }
                }
                else
                {
                    Sale sale = new Sale() { Furniture = currentFurniture, Quantity = quantity };
                    SaleStatic.Sales.Add(sale);
                }
                this.DialogResult = DialogResult.Retry;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var newFurniture = GetDataFromUserControls();
            bool done = controller.Update(newFurniture);
            if (done == true)
            {
                lblAnswer.Text = "Выполнено";
                lblAnswer.ForeColor = Color.DarkGreen;
                await Task.Delay(1500);
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                lblAnswer.Text = "Не выполнено";
                lblAnswer.ForeColor = Color.Red;
            }    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetDataInUserControls(int id, string name)
        {
            var furniture = controller.GetById(id);
            currentFurniture = furniture;
            tbCategory.Text = name;
            tbModel.Text = currentFurniture.Model;
            tbSpecifications.Text = currentFurniture.Specifications;
            tbCost.Text = currentFurniture.Cost.ToString();
        }
        private Furniture GetDataFromUserControls()
        {
            Furniture furniture = new Furniture();
            int number;
            if (int.TryParse(tbCost.Text, out number))
            {
                furniture.Cost = number;
                furniture.Id = currentFurniture.Id;
                furniture.Model = tbModel.Text;
                furniture.Specifications = tbSpecifications.Text;
            }
            return furniture;
        }
    }
}
