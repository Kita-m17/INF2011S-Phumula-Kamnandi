using Phumla_Kamnandi_project.Business;
using Phumla_Kamnandi_project.Data;
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
using static Phumla_Kamnandi_project.Presentation.ManageBookings;
using static System.Windows.Forms.AxHost;

namespace Phumla_Kamnandi_project
{
    public partial class Make_a_Booking : Form
    {
        private Booking booking = new Booking();
        private BookingController bookingController;

        public Booking getBooking
        {
            get {  return booking; }
        }
        public Make_a_Booking()
        {
            InitializeComponent();
            FormClosing += Make_a_Booking_FormClosing;
            //signInDateTimePicker.MinDate = DateTime.Today;
            //signOutDateTimePicker.MinDate = DateTime.Today;
            bookingController = new BookingController();
        }


        public Make_a_Booking(BookingController aController)
        {
            InitializeComponent();
            FormClosing += Make_a_Booking_FormClosing;
            //signInDateTimePicker.MinDate = DateTime.Today;
            //signOutDateTimePicker.MinDate = DateTime.Today;
            bookingController = new BookingController();
            bookingController = aController;
        }

        private void ClearAll(bool value)
        {

        }

        public void PopulateObject()
        {
            booking.HotelID = "HID001";
            booking.SignInDate = signInDateTimePicker.Value;
            booking.SignOutDate = signOutDateTimePicker.Value;
            booking.NumAdults = (int)adultsNumericUpDown.Value;
            booking.NumChildren = (int)childrenNumericUpdown.Value;
            //HardCoded - need to do room allocation here!
            booking.RoomID = "RID001";
            int numRooms = (int)roomsNumericUpDown.Value;

            int numAdults = (int)adultsNumericUpDown.Value;
            int numChildren = (int)childrenNumericUpdown.Value;
            int adultRooms = (numAdults + 1) / 2; //ceiling value
            int childrenRooms = (numChildren + 1) / 2; //ceiling value
            int minimumRooms = Math.Max(childrenRooms, adultRooms);

            booking.NumRooms = minimumRooms;
            
        }

        private void make_a_booking_Load(object sender, EventArgs e)
        {
            bookingController = new BookingController();
        }

        private void nextButton1_Click(object sender, EventArgs e)
        {
            //validate all fields first before going to next page
            if (validation())
            {
                //PopulateObject();
                DateTime signInDate = signInDateTimePicker.Value;        // Get sign-in date
                DateTime signOutDate = signOutDateTimePicker.Value;      // Get sign-out date
                int numRoomsRequested = (int)roomsNumericUpDown.Value;   // Get the number of rooms requested

                // Step 1: Check room availability for the selected dates and number of rooms
                bool canBook = bookingController.AreRoomsAvailable("HID001", signInDate, signOutDate, numRoomsRequested);
                if (canBook)
                {
                    PopulateObject();
                    // Go from Booking details to make a booking 2 
                    Make_a_booking_2 make_a_booking_2 = new Make_a_booking_2(booking, bookingController);
                    make_a_booking_2.Show();
                    this.Hide();
                }
                else
                {
                    // Notify the user that no rooms are available for the selected dates
                    MessageBox.Show("Sorry, there are not enough rooms available for the selected dates. Please choose a different date range or reduce the number of rooms.");
                }
            }

        }

        //this method handles all validations related to this form
        private bool validation()
        {
           
            //signin date must be before sign out date
            DateTime signIn = signInDateTimePicker.Value;
            DateTime signOut = signOutDateTimePicker.Value;
            if (signIn >= signOut)
            {
                MessageBox.Show("Sign-in date must be before sign-out date.");
                signInDateTimePicker.Focus();
                return false;
            }

            
            // hotel must exist in the combo list
            if (HotelsComboBox.Items.Contains(HotelsComboBox.Text) == false)
            {
                MessageBox.Show("Please select an existing hotel.");
                HotelsComboBox.Focus();
                return false;
            }

            // the number of rooms entered must be valid for the number of guests
            // might have to re-evaluate this implementation/method 
            int numAdults = (int)adultsNumericUpDown.Value;
            int numChildren = (int)childrenNumericUpdown.Value;
            int adultRooms = (numAdults + 1) / 2; //ceiling value
            int childrenRooms = (numChildren + 1) / 2; //ceiling value
            int minimumRooms = Math.Max(childrenRooms, adultRooms); 
            if (roomsNumericUpDown.Value < minimumRooms)
            {
                MessageBox.Show("More rooms are required for these guests.");
                roomsNumericUpDown.Focus();
                return false;
            }

            return true;

        }

        private void PopulateHotelsComboBox()
        {
            HotelsComboBox.Items.Add("Richmond");

            HotelsComboBox.SelectedIndex = 0;
            HotelsComboBox.Enabled = false;
        }

        private void Make_a_Booking_Load(object sender, EventArgs e)
        {
            PopulateHotelsComboBox();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            menupage menupage = new menupage();
            menupage.Show(this);
            this.Hide();
        }

        public void Make_a_Booking_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
