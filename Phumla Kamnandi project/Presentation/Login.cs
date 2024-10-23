using Phumla_Kamnandi_project.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project
{
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
            passWordTextBox.UseSystemPasswordChar = true;
            FormClosing += Login_FormClosing;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void ClearAll(bool value)
        {
            userNameTextBox.Text = "";
            passWordTextBox.Text = "";
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from text boxes
            string userName = userNameTextBox.Text;
            string password = passWordTextBox.Text;

            // Check if username and password are not empty
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both your username and password.");
                return;
            }

            // Create an instance of the LoginController
            LoginController loginController = new LoginController();

            // Verify login credentials
            bool loginSuccess = loginController.VerifyLogin(userName, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login Successful!");
                OpenMenuPage(); // Call method to open the menu page
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void OpenMenuPage()
        {
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }

        private void viewPasswordButton_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                passWordTextBox.UseSystemPasswordChar = true; // Hide password.
            }
            else
            {
                passWordTextBox.UseSystemPasswordChar = false; // Show password.
            }
            isPasswordVisible = !isPasswordVisible; // Toggle the visibility state.
        }

        #region Delete
        private void cancelButton_Click(object sender, EventArgs e)
        {
            userNameTextBox.Clear();
            passWordTextBox.Clear();
            Welcome_page welcomePage = new Welcome_page();
            welcomePage.Show();
            this.Hide();
        }
        #endregion

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}