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
    public partial class AuthentificationForm : Form
    {
        public AuthentificationForm()
        {
            InitializeComponent();
           
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            User user = new User() {Login = tbLogin.Text, Password = tbPassword.Text};
            UserController userController = new UserController();
            if(userController.LogIn(user))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                lblStatus.Text = "Вход не выполнен";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

        }

        private void AuthentificationForm_Load(object sender, EventArgs e)
        {
            tbLogin.Text = "Maria1";
            tbPassword.Text = "Maria";
            lblStatus.Text = "";
        }
    }
}
