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
    public partial class FurnitureDetails : Form
    {
        private FurnitureFurnitureForDGVDto Furniture { get; set; }
        private FurnitureController controller = new FurnitureController();
        private Size windowsSize;
        public FurnitureDetails(int id, string name)
        {
            InitializeComponent();
            if(CurrentUser.isCustomer == true)
            {
                tbFurnitureName.ReadOnly = true;
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
        }

        private void FurnitureDetails_Load(object sender, EventArgs e)
        {
            lblAnswer.Text = "";
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

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
            Furniture = furniture;
            tbFurnitureName.Text = name;
            tbModel.Text = Furniture.Model;
            tbSpecifications.Text = Furniture.Specifications;
            tbCost.Text = Furniture.Cost.ToString();
        }
        private FurnitureFurnitureForDGVDto GetDataFromUserControls()
        {
            FurnitureFurnitureForDGVDto furniture = new FurnitureFurnitureForDGVDto();
            int number;
            if (int.TryParse(tbCost.Text, out number))
            {
                furniture.Cost = number;
                furniture.Id = Furniture.Id;
                furniture.Model = tbModel.Text;
                furniture.Specifications = tbSpecifications.Text;
            }
            return furniture;
        }
    }
}
