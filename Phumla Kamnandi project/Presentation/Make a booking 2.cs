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
using Phumla_Kamnandi_project.Data;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text.RegularExpressions;

namespace Phumla_Kamnandi_project.Presentation
{
    public partial class Make_a_booking_2 : Form
    {
        private Guest guest;
        private GuestController guestController;
        private Booking booking;
        private BookingController bookingController;
        private BookingDB bookingDB;
        public Make_a_booking_2(Booking aBooking, BookingController bookingController)
        {
            InitializeComponent();
            FormClosing += Make_a_booking_2_FormClosing;
            guest = new Guest();
            guestController = new GuestController();
            this.booking = aBooking;
            this.bookingController = bookingController;
            bookingDB = new BookingDB();
        }

        public Make_a_booking_2()
        {
            InitializeComponent();
            guest = new Guest();
            guestController = new GuestController();
            bookingDB = new BookingDB();
        }

        public void PopulateObject()
        {
            guest.GuestID = idTextBox.Text;
            guest.Name = nameTextBox.Text;
            guest.Surname = surnameTextBox.Text;
            guest.Email = emailTextBox.Text;
            guest.PhoneNumber = phoneTextBox.Text;
            guest.Address = addressTextBox.Text;

            booking.GuestID = guest.GuestID;
        }

        public void ClearAll()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            emailTextBox.Text = "";
            phoneTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void backButton2_Click(object sender, EventArgs e)
        {

            Make_a_Booking make_A_Booking = new Make_a_Booking();
            
            make_A_Booking.Show();
            this.Hide();
        }

        private void nextButton2_Click(object sender, EventArgs e)
        {
            bool validity = validation();
            if (validity)
            {
                MessageBox.Show("The record will be submitted to the database.");
                PopulateObject();
                bool guestSuccess = true;
                try
                {
                    Guest existingGuest = guestController.Find(guest.GuestID);

                    if (existingGuest != null)
                    {
                        // Update guest details if already exists
                        guestController.DataMaintenance(guest, Database.DBOperation.Edit);
                        guestSuccess = guestController.FinalizeChanges(guest, Database.DBOperation.Edit);
                    }
                    else
                    {
                        // Add new guest if not found
                        guestController.DataMaintenance(guest, Database.DBOperation.Add);
                        guestSuccess = guestController.FinalizeChanges(guest, Database.DBOperation.Add);
                    }

                    if (guestSuccess)
                    {
                        bookingController.DataMaintenance(booking, Data.Database.DBOperation.Add);
                        bool bookingSuccess = bookingController.FinalizeChanges(booking, Database.DBOperation.Add);
                        if (bookingSuccess)
                        {
                            Make_a_Booking_3 make_A_Booking3 = new Make_a_Booking_3(booking, guest);
                            make_A_Booking3.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add booking to the database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to add guest to the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Not valid");
            }

        }

        private bool validation() //this method handles validation in this form
        {
            string id = idTextBox.Text;
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string phoneNumber = phoneTextBox.Text;
            string email = emailTextBox.Text;
            bool goToNext = true; //if none of the conditions change this variable to false, all is well
            bool idError1 = false;
            bool idError2 = false;
            //bool idError3 = checkID(id); // is the id itself valid?

            //id must contain numbers only
            foreach (char digit in id)
            {
              if (char.IsDigit(digit) == false)
              {
                    idError1 = true;
                    idTextBox.Focus();
                    goToNext = false;
                    break;
              }
             // else idErrorLabel.Visible=false;
            }

            //id must be 13 digits long
            if (id.Length != 13)
            {
                idError2 = true;
                idTextBox.Focus(); 
                goToNext = false;
            } //else idErrorLabel.Visible=false;

            if (idError1 || idError2) { idErrorLabel.Visible = true; }
            else idErrorLabel.Visible = false;

            //Name must not be an empty string
            if (name.Equals(""))
            {
                nameErrorLabel.Visible = true;
                nameTextBox.Focus();
                goToNext = false;
            }
            else nameErrorLabel.Visible = false;

            //name must have letters only
            foreach (char letter in name)
            {
                if (char.IsLetter(letter) == false)
                {
                    nameErrorLabel.Visible = true;
                    nameTextBox.Focus();
                    goToNext = false;
                    break;
                }
                else nameErrorLabel.Visible=false;
            }

            //Surname must not be an empty string
            if (surname.Equals(""))
            {
                surnameErrorLabel.Visible = true;
                surnameTextBox.Focus();
                goToNext = false;
            }
            else surnameErrorLabel.Visible = false;

            //surname must have letters only
            foreach (char letter in surname)
            {
                if (char.IsLetter(letter) == false)
                {
                    surnameErrorLabel.Visible = true;
                    surnameTextBox.Focus();
                    goToNext = false;
                    break;
                }
                else surnameErrorLabel.Visible=false;
            }
            bool phoneError1 = false;
            bool phoneError2 = false;
            //phone number must have numeric digits only
            foreach (char digit in phoneNumber)
            {
                if (char.IsDigit(digit) == false)
                {
                    phoneError1 = true;
                    phoneTextBox.Focus();
                    goToNext = false;
                    break;
                }
                //else phoneErrorLabel.Visible = false;
            }

            //phone number must have 10 digits and start with a 0
            if ((phoneNumber.Length != 10) || (phoneNumber[0].Equals('0')) == false)
            {
                phoneError2 = true;
                phoneTextBox.Focus();
                goToNext = false;
            }

            if (phoneError1 == true || phoneError2 == true) { phoneErrorLabel.Visible = true; }
            else {  phoneErrorLabel.Visible = false; }
             
            //email must have an @ symbol in it and no spaces in the email
            if (!validEmail(email))
            {
                emailErrorLabel.Visible = true;
                emailTextBox.Focus();
                goToNext = false;
            } else emailErrorLabel.Visible = false;


            return goToNext;
        }

        private bool validEmail(string email)
        {
            string format = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // the format a valid email must follow
            return Regex.IsMatch(email, format); // does the email match this format?
        }

        private bool checkID(string id)
        {
            // date of birth 
            string sYear = id.Substring(0, 2);
            string sMonth = id.Substring(2, 2);
            string sDay = id.Substring(4, 2);
            int intYear = int.Parse(sYear);
            int intMonth = int.Parse(sMonth);
            int intDay = int.Parse(sDay);

            // month greater than 12 does not exist
            if (intMonth > 12) { return false; }


            //checking for valid dates
            int daysInMonth = DateTime.DaysInMonth(intYear, intMonth);
            if (intDay > daysInMonth) { return false; }

            //check nationality, 11th digit must be a 0 or 1
            string sNationality = id.Substring(10, 1);
            int intNationality = int.Parse(sNationality);
            if (intNationality != 0 || intNationality != 1) { return false; }

            return true;
        }

        private void make_a_booking_2(object sender, EventArgs e)
        {
            guestController = new GuestController();
        }

        private void surnameErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Make_a_booking_2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
