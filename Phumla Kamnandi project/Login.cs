using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearAll(bool value)
        {
            userNameTextBox.Text = "";
            passWordTextBox.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passWordTextBox.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both the username and password");
                return;
            }
            login();//for now - place holder

            /*
            bool loginSuccess = verifyLogin(userName, password);

            if (loginSuccess)
            {
                MessageBox.Show("Login successfull");
                login();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.")
            }
            */
        }

        /*
         * Method that searches the database to see if the username and password matches an existing receptionist
         * -need to connect to the db
        private bool verifyLogin(string userName, string password) {
            
        }
        */

        private void login()
        {
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }

        /*
         * Debatable
        private void ShowAll(bool value)
        {
            userNameLabel.Visible = value;
            userNameTextBox.Visible = value;
            passWordLabel.Visible = value;
            passWordTextBox.Visible = value;

            if((userNameTextBox.Text.Equals("")) && (passWordTextBox.Text.Equals("")))
            {
                loginButton.Visible = !value;
            }
            else
            {
                loginButton.Visible = value;
            }
        }
        */

    }
}
