using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_project.Business;

namespace Phumla_Kamnandi_project.Presentation
{
    public partial class Make_a_Booking_3 : Form
    {
        
        private Booking booking;
        private Guest guest = new Guest();
        private HotelController hotelController = new HotelController();
        private Collection<Hotel> hotels;
        public Make_a_Booking_3(Booking booking, Guest guest)
        {
            InitializeComponent();
            FormClosing += Make_a_Booking_3_FormClosing;
            this.booking = booking;
            this.guest = guest;
            hotels = hotelController.AllHotels;
            PrintSummary();
        }

        private void PrintSummary()
        {
            if (guest==null || booking == null)
            {
                MessageBox.Show("Guest or Booking information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string guestFullName = guest.Name + " " + guest.Surname;
            guestNameLabel.Text = guestFullName;
            signInLabel.Text = booking.SignInDate.ToString("yyyy-MM-dd");
            signOutLabel.Text = booking.SignOutDate.ToString("yyyy-MM-dd");
            signOutLabel.Text = booking.SignOutDate.ToString("yyyy-MM-dd");

            numRoomsLabel.Text = booking.NumRooms.ToString();
            string hotelName = "";

            foreach (Hotel hotel in hotels)
            {
                if (booking.HotelID.Equals(hotel.HotelID))
                {
                    hotelName = hotel.HotelName;
                    break;
                }
            }
            hotelNameLabel.Text = hotelName;

            totalCostLabel.Text = "R " + booking.getBookingAmount().ToString();
            depositAmountLabel.Text = "R " + booking.getBookingDeposit().ToString();
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            Make_a_booking_2 make_A_Booking2 = new Make_a_booking_2();
            make_A_Booking2.Show();
            this.Hide();
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            Make_a_Booking_4 make_A_Booking4 = new Make_a_Booking_4(booking, guest);
            make_A_Booking4.Show();
            this.Hide();
        }

        private void Make_a_Booking_3_Load(object sender, EventArgs e)
        {
            PrintSummary();
        }

        public void Make_a_Booking_3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}