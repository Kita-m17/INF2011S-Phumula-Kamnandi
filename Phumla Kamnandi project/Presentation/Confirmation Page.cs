using Phumla_Kamnandi_project.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project.Presentation
{
    public partial class Confirmation_Page : Form
    {
        private Booking booking;
        private Guest guest;
        public Confirmation_Page(Booking booking, Guest guest)
        {
            InitializeComponent();
            this.booking = booking;
            this.guest = guest;
            displayRefNumber();
        }

        private void displayRefNumber()
        {
            reservationNumLabel.Text = booking.BookingID.ToString();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }
    }
}
