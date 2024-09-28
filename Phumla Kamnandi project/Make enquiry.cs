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
    public partial class Make_enquiry : Form
    {
        public Make_enquiry()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Make_enquiry_Load(object sender, EventArgs e)
        {

        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            Make_a_Booking make_A_Booking = new Make_a_Booking();
            make_A_Booking.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //going back to the menu page 
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }
    }
}
