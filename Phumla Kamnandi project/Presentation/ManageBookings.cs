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
using Phumla_Kamnandi_project.Data;
using static Phumla_Kamnandi_project.Presentation.ManageBookings;

namespace Phumla_Kamnandi_project.Presentation
{
    public partial class ManageBookings : Form
    {

        private bool formClosed;
        private Collection<Booking> bookings = new Collection<Booking>();
        private BookingController bookingController;
        private Booking booking ;
        public enum FormState {
            View = 0, Add = 1, Edit = 2, Delete = 3,
        }

        protected FormState state;

        public FormState State {
            get { return state; }
            set { state = value; }
        }

        public ManageBookings(BookingController bookingController)
        {
            InitializeComponent();
            this.bookingController = bookingController;
            this.Load += ManageBookings_Load;
            this.Activated += ManageBookings_Activated;
            this.FormClosed += ManageBookings_FormClosed;
            state = FormState.View;
            this.booking = new Booking();
            EnableEntries(false);
        }

        public ManageBookings()
        {
            InitializeComponent();
            this.Load += ManageBookings_Load;
            this.Activated += ManageBookings_Activated;
            this.FormClosed += ManageBookings_FormClosed;
            state = FormState.View;
            EnableEntries(false);
        }

        private void ManageBookings_FormClosed(object sender, FormClosedEventArgs e)
        {
            formClosed = true;
        }

        private void ManageBookings_Activated(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
            setUpBookingListView();
            ShowAll(true);
            state =FormState.View;
            EnableEntries(false);
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            bookingListView.View = View.Details;
        }

        public void setUpBookingListView()
        {
            ListViewItem bookingDetails;
            bookings = null;
            bookings = bookingController.AllBookings;
            bookingListView.Clear();


            bookingListView.Columns.Insert(0, "Booking ID", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(1, "Guest Name", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(2, "Hotel Name", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(3, "Sign-In Date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(4, "Sign-Out Date", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(5, "Number of Rooms", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(6, "Number of Children", 120, HorizontalAlignment.Left);
            bookingListView.Columns.Insert(7, "Number of Adults", 120, HorizontalAlignment.Left);
            

            if (bookings == null)
            {
                MessageBox.Show("No bookings available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);    
            }

            foreach (Booking bookingItem in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = bookingItem.BookingID.ToString();
                Guest guest = bookingItem.getGuest();
                if (guest != null)
                {
                    bookingDetails.SubItems.Add(guest.Name.ToString());
                }
                else
                {
                    bookingDetails.SubItems.Add(bookingItem.GuestID.ToString());
                }
                
                Hotel hotel = bookingItem.getHotel();
                bookingDetails.SubItems.Add(hotel.HotelName.ToString());
                bookingDetails.SubItems.Add(bookingItem.SignInDate.ToString());
                bookingDetails.SubItems.Add(bookingItem.SignOutDate.ToString());
                bookingDetails.SubItems.Add(bookingItem.NumRooms.ToString());
                bookingDetails.SubItems.Add(bookingItem.NumChildren.ToString());
                bookingDetails.SubItems.Add(bookingItem.NumAdults.ToString());
                
                bookingListView.Items.Add(bookingDetails);
            }
            bookingListView.Refresh();
            bookingListView.GridLines = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // go back to main menu
            menupage menupage = new menupage();
            menupage.Show();
            this.Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // validate information in edit boxes before updating database
            bool validity = validation();
            state = FormState.Edit;
            EnableEntries(true);
        }

        private void PopulateTextBoxes(Booking booking)
        {
            hotelComboBox.Text = booking.HotelID;
            
            signInDateTimePicker.Value = booking.SignInDate;
            signOutDateTimePicker.Value = booking.SignOutDate;
            adultsNumericUpDown.Value = booking.NumAdults;
            childrenNumericUpDown.Value = booking.NumChildren;
            roomsNumericUpDown.Value = booking.NumRooms;
        }

        private void EnableEntries(bool value)
        {
            if ((state == FormState.Edit) && value)
            {
                hotelComboBox.Enabled = !value;
                editButton.Enabled = !value;
                deleteButton.Enabled = !value;
            }
            else
            {
                hotelComboBox.Enabled = value;
                editButton.Enabled = value;
                deleteButton.Enabled = value;
            }
            hotelComboBox.Enabled = false;
            signInDateTimePicker.Enabled = value;
            signOutDateTimePicker.Enabled = value;
            adultsNumericUpDown.Enabled = value;
            roomsNumericUpDown.Enabled = value;
            childrenNumericUpDown.Enabled = value;

            if ((state == FormState.Delete))
            {
                submitButton.Visible = !value;
                cancelButton.Visible = value;
                deleteButton.Enabled = !value;
                editButton.Enabled = !value;
            }
            else
            {
                submitButton.Visible = value;
                cancelButton.Visible = value;
                deleteButton.Enabled = value;
            }
        }

        private void ShowAll(bool value)
        {
            hotelComboBox.Visible = value;
            signInDateTimePicker.Visible = value;
            signOutDateTimePicker.Visible= value;
            childrenNumericUpDown.Visible = value;
            adultsNumericUpDown.Visible = value;
            roomsNumericUpDown.Visible = value;

            if (state == FormState.View)
            {
                submitButton.Visible = !value;
                cancelButton.Visible = !value;
            }
            else
            {
                submitButton.Visible = value;
                cancelButton.Visible = value;
            }
        }
        private void ClearAll()
        {
            hotelComboBox.Text = "";
            signInDateTimePicker.DataBindings.Clear();
            signOutDateTimePicker.DataBindings.Clear();
            childrenNumericUpDown.Value = 0;
            adultsNumericUpDown.Value = 1;
            roomsNumericUpDown.Value = 1;
        }

        private bool validation()
        {
            //get all input
            string hotel = hotelComboBox.Text;
            DateTime signIn = signInDateTimePicker.Value;
            DateTime signOut = signOutDateTimePicker.Value;
            int adults = (int)adultsNumericUpDown.Value;
            int children = (int)childrenNumericUpDown.Value;
            int numRooms = (int)roomsNumericUpDown.Value;
            bool valid = true;

            //sign in must be before sign out
            if (signIn >= signOut)
            {
                MessageBox.Show("Sign-in date must be before sign-out date.");
                signInDateTimePicker.Focus();
                valid = false;
            }

            // entered number of rooms must be enough for the guests
            int adultRooms = (adults + 1) / 2; //ceiling value
            int childrenRooms = (children + 1) / 2; //ceiling value
            int minimumRooms = Math.Max(childrenRooms, adultRooms);
            if (roomsNumericUpDown.Value < minimumRooms)
            {
                MessageBox.Show("More rooms are required for these guests.");
                roomsNumericUpDown.Focus();
                valid = false;
            }
            return valid;
        }

        private void PopulateObject()
        {
            booking.HotelID = hotelComboBox.Text;
            booking.SignInDate = signInDateTimePicker.Value;
            booking.SignOutDate = signOutDateTimePicker.Value;
            booking.NumChildren = (int)childrenNumericUpDown.Value;
            booking.NumAdults = (int)adultsNumericUpDown.Value;
            booking.NumRooms = (int)roomsNumericUpDown.Value;

        }

        private void bookingListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowAll(true);
            state = FormState.View;
            EnableEntries(false);
            if (bookingListView.SelectedItems.Count > 0) // if you selected an item
            {
               booking = bookingController.Find(bookingListView.SelectedItems[0].Text);
               PopulateTextBoxes(booking);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            EnableEntries(false);
            state = FormState.View;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                state = FormState.Delete;
                EnableEntries(true);
                bookingController.DataMaintenance(booking, Database.DBOperation.Delete);
                bookingController.FinalizeChanges(booking, Database.DBOperation.Delete);
            }
            ClearAll();
            state = FormState.View;
            EnableEntries(false);
            setUpBookingListView();
        }

        private void bookingListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormState.View;
            EnableEntries(true);
            if (bookingListView.SelectedItems.Count > 0) // if you selected an item
            {
                booking = bookingController.Find(bookingListView.SelectedItems[0].Text);
                PopulateTextBoxes(booking);
            }
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this booking?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                PopulateObject();
                if (state == FormState.Edit)
                {
                    bookingController.DataMaintenance(booking, Database.DBOperation.Edit);
                }
                bookingController.FinalizeChanges(booking, Database.DBOperation.Edit);
            }
            ClearAll();
            state = FormState.View;
            EnableEntries(false);
            setUpBookingListView();
        }
    }
}