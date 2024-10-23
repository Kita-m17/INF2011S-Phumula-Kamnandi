using Phumla_Kamnandi_project.Business;
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

namespace Phumla_Kamnandi_project
{
    public partial class Make_enquiry : Form
    {
        private HotelController hotelController = new HotelController();
        private BookingController bookingController = new BookingController();
        private Collection<Hotel> hotels;
        public Make_enquiry()
        {
            InitializeComponent();
            
            hotels = hotelController.AllHotels;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Make_enquiry_Load(object sender, EventArgs e)
        {
            PopulateHotelsComboBox();
        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            Make_a_Booking make_A_Booking = new Make_a_Booking();
            make_A_Booking.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            validation();
            string hotelName = HotelsComboBox.Text;
            DateTime signIn = signInDateTimePicker.Value;
            DateTime signOut = signOutDateTimePicker.Value;

            int availableRooms = bookingController.getAvailableRooms("HID001", signIn, signOut);
            Hotel aHotel = new Hotel();
            foreach(Hotel hotel in hotels)
            {
                if (hotel.HotelID.Equals("HID001"))
                {
                    aHotel = hotel;
                }
            }

            rateLabel.Text = "R"+aHotel.getRate(signIn, signOut).ToString();
            availRoomsLabel.Text = bookingController.getAvailableRooms("HID001", signIn, signOut).ToString();
            if (bookingController.getAvailableRooms("HID001", signIn, signOut) < 0) { availRoomsLabel.Text = "0"; }
        }

        private void PopulateHotelsComboBox()
        {
            HotelsComboBox.Items.Add("Richmond");

            HotelsComboBox.SelectedIndex = 0;
            HotelsComboBox.Enabled = false;
        }
        private void validation()
        {
            //signin date must be before sign out date
            DateTime signIn = signInDateTimePicker.Value;
            DateTime signOut = signOutDateTimePicker.Value;
            if (signIn >= signOut)
            {
                MessageBox.Show("Sign-in date must be before sign-out date.");
                signInDateTimePicker.Focus();
                //return;
            }

            //a hotel must be selected
            if (HotelsComboBox.Text.Equals(""))
            {
                MessageBox.Show("Please select a hotel.");
                HotelsComboBox.Focus();
                //return;
            }
        }
    }
}
