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
    public partial class menupage : Form
    {
        public menupage()
        {
            InitializeComponent();
        }

        private void makeEnquiryButton_Click(object sender, EventArgs e)
        {
            Make_enquiry make_Enquiry = new Make_enquiry();
            make_Enquiry.Show();
            this.Hide();
        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            Make_a_Booking make_A_Booking = new Make_a_Booking();
            make_A_Booking.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Welcome_page welcome_Page = new Welcome_page();
            welcome_Page.Show();
            this.Hide();
        }
    }
}
