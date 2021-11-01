using FurnitureSalesCompanyProject.Controllers;
using FurnitureSalesCompanyProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureSalesCompanyProject.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            lblValid.MaximumSize = new Size(300, 100);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblValid.Text = "";
            MyValidate myValidate = isValidRegistration();
            UserController userController = new UserController();
            if (myValidate.isSuccess == true)
            {
                Customer customer = new Customer()
                {
                    Login = tbLogin.Text,
                    Password = tbPassword.Text,
                    Name = tbName.Text,
                    Address = tbAddress.Text,
                    Phone = tbPhone.Text
                };
                bool isRegistr = userController.SignIn(customer);
                if (isRegistr)
                {
                    MessageBox.Show("Успешно");
                    this.Close();
                }
                else
                    MessageBox.Show("Пользователь с таким логином уже существует");
            }
            else
                lblValid.Text = myValidate.Message;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private MyValidate isValidRegistration()
        {
            MyValidate myValidate = new MyValidate();
            string phoneRegex = @"((8|\+7)-?)?\(?\d{3}\)?-?\d{1}-?\d{1}-?\d{1}-?\d{1}-?\d{1}-?\d{1}-?\d{1}";

            if(string.IsNullOrWhiteSpace(tbLogin.Text)||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text)||
                string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                myValidate.Message = "Поля не должны быть пустыми";
                return myValidate;
            }
            if(!Regex.IsMatch(tbPhone.Text, phoneRegex))
            {
                myValidate.Message = "Некоректно заполнен номер";
                return myValidate; 
            }
            myValidate.isSuccess = true;
            return myValidate;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            lblValid.Text = "";
        }
    }
    
}
