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
    public partial class MainForm : Form
    {
        private Form activateForm;
        private Button currentButton;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            StartApplication();
            SetCounter(0);
            if (CurrentUser.isCustomer == true)
            {
                btnOpenCustomersForm.Visible = false;
                btnOpenContructsForm.Visible = false;
                
            }
            if (CurrentUser.isCustomer == false)
            {
                btnOpenCartForm.Visible = false;
                btnOpenContractsHistoryForm.Visible = false;
                btnOpenCustomersForm.Visible = false;
            }
            if(CurrentUser.isAdmin == true)
            {
                btnOpenFurnituresForm.Visible = false;
                btnOpenContructsForm.Visible = false;
                btnOpenCartForm.Visible = false;
                btnOpenContractsHistoryForm.Visible = false;
                btnOpenCustomersForm.Visible = true;
            }
            if(CurrentUser.User != null)
                this.Text += $"\t ( {CurrentUser.User.Login} )";
        }
        private void btnCustomers_MouseHover(object sender, EventArgs e)
        {
            btnOpenCustomersForm.BackColor = Color.FromArgb(91,61,81);
        }
        private void btnOpenFurnituresForm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            var furnitureForm = new FurnitureForm();
            OpenChildForm(furnitureForm, sender);
            furnitureForm.FurnitureSold += SetCounter;
        }
        
        private void SetCounter(int count)
        {
            btnOpenCartForm.Text = $"   Корзина ({count})";
        }
        private void btnOpenCustomersForm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new CustomersForm(), sender);
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activateForm != null)
                activateForm.Close();
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(91, 61, 61);
                    currentButton.Font = new Font("Perpetua", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuTab.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(111, 61, 71);
                    previousBtn.Font = new Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SaleStatic.Sales = new List<Sale>();
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
        private void StartApplication()
        {
            AuthentificationForm authentification = new AuthentificationForm();
            authentification.ShowDialog();
            if (authentification.DialogResult != DialogResult.Yes)
                this.Close();
        }

        private void btnOpenCartForm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            var cartForm = new CartForm();
            cartForm.Click_btnResetCart += SetCounter;
            OpenChildForm(cartForm, sender);
        }
        
        private void btnOpenContractsHistoryForm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ContractsHistoryForm(), sender);
        }

        private void btnOpenContructsForm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new ContractsForm(), sender);
        }

    }
}
