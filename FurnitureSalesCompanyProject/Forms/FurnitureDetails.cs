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
    public partial class FurnitureDetails : Form
    {
        private Furniture Furniture { get; set; }
        public FurnitureDetails()
        {
            InitializeComponent();
        }
        public FurnitureDetails(Furniture furniture) : base()
        {
            InitializeComponent();
            Furniture = furniture;
        }

        private void FurnitureDetails_Load(object sender, EventArgs e)
        {
            lblName.Text = Furniture.Model;
            lblFurnitureName.Text = Furniture.FurnitureName.Name;
            lblSpecifications.Text = Furniture.Specifications;
            lblCost.Text = Furniture.Cost.ToString();
        }
    }
}
