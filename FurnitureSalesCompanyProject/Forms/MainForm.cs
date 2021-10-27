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
            StartApplication();
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.isCustomer == true)
            {
                btnOpenCustomersForm.Visible = false;
            }
        }
        private void btnCustomers_MouseHover(object sender, EventArgs e)
        {
            btnOpenCustomersForm.BackColor = Color.FromArgb(91,61,81);
        }
        private void btnOpenFurnituresForm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FurnitureForm(), sender);
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
                    previousBtn.BackColor = Color.FromArgb(111, 61, 81);
                    previousBtn.Font = new Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
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
    }
}
