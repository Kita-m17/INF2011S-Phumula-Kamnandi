using Phumla_Kamnandi_project.Business;
using Phumla_Kamnandi_project.Presentation;
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
        BookingController bookingController = new BookingController();
        public menupage()
        {
            InitializeComponent();
            FormClosing += menupage_FormClosing;
            
        }

        private void makeEnquiryButton_Click(object sender, EventArgs e)
        {
            Make_enquiry make_Enquiry = new Make_enquiry();
            make_Enquiry.Show();
            this.Hide();
        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            Make_a_Booking make_A_Booking = new Make_a_Booking(bookingController);
            make_A_Booking.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
           /* Welcome_page welcome_Page = new Welcome_page();
            welcome_Page.Show();
            this.Hide();*/
           Environment.Exit(0);
        }

        private void manageBookingbutton_Click(object sender, EventArgs e)
        {
            // go to manage bookings page
            ManageBookings manageBookings = new ManageBookings(bookingController);
            manageBookings.Show();
            this.Hide();

        }

        private void generateReportsButton_Click(object sender, EventArgs e)
        {
            //show popup
            reportsPanel.Visible = true;
        }

        private void occupancyButton_Click(object sender, EventArgs e)
        {
            // go to occupancy report
            OccupancyReport occupancyReport = new OccupancyReport();
            occupancyReport.Show();
            this.Hide();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            SummaryReport summaryReport = new SummaryReport();
            summaryReport.Show();
            this.Hide();
        }

        public void menupage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
