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
    public partial class Welcome_page : Form
    {
        public Welcome_page()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }
    }
}
