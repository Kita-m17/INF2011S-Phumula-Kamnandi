using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Phumla_Kamnandi_project.Business;

namespace Phumla_Kamnandi_project.Presentation
{
    public partial class Make_a_Booking_4 : Form
    {
        private Booking booking;
        private Guest guest;
        public Make_a_Booking_4(Booking booking, Guest guest)
        {
            InitializeComponent();
            expiryDateTimePicker.MinDate = DateTime.Today;
            this.booking = booking;
            this.guest = guest;
        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            Make_a_Booking_3 make_A_Booking3 = new Make_a_Booking_3(booking, guest);
            make_A_Booking3.Show();
            this.Hide();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool validity = validation();
            if (validity) // if all fields are valid, go to confirmation page
            {
                Confirmation_Page confirmation_Page = new Confirmation_Page(booking, guest);
                confirmation_Page.Show();
                this.Hide();
            }
        }

        private bool validation()
        {
            string creditCardNumber = ccNumberTextBox.Text;
            DateTime expiryDate = expiryDateTimePicker.Value;
            string holderName = holderNameTextBox.Text;
            string cvv = cvvTextBox.Text;
            bool goToNext = true;

            //creditcard number must have numbers only
            bool ccError1 = false;
            bool ccError2 = false;

            foreach (char digit in creditCardNumber)
            {
                if (char.IsDigit(digit) == false)
                {
                    ccError1 = true;
                    ccNumberTextBox.Focus();
                    goToNext = false;
                    break;
                }
            }

            //credit card number must have 16 digits
            if (creditCardNumber.Length!= 16)
            {
                ccError2 = true;
                ccNumberTextBox.Focus();
                goToNext = false;
            }
            if (ccError1 || ccError2) { ccNumberErrorLabel.Visible = true; }
            else ccNumberErrorLabel.Visible = false;


            // minimum expiry date set to today so receptionist cannot enter a past date
            bool cvvErr1 = false;
            bool cvvErr2 = false; //to manage the error label
            //cvv number must have numbers only
            foreach (char digit in cvv)
            {
                if (char.IsDigit(digit) == false)
                {
                    cvvErr1 = true;
                    cvvTextBox.Focus();
                    goToNext = false;
                    break;
                }//else cvvErrorLabel.Visible=false;
            }

            // cvv must be 3 digits long
            if (cvv.Length != 3)
            {
                cvvErr2 = true;
                cvvTextBox.Focus();
                goToNext = false;
            } //else cvvErrorLabel.Visible = false;
            if (cvvErr1 == true || cvvErr2 == true) { cvvErrorLabel.Visible = true; }
            else cvvErrorLabel.Visible = false;
            return goToNext;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
