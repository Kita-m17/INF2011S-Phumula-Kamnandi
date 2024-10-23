using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    internal class SummaryReportClass
    {
        #region Data Members
        private string reportId;
        private DateTime reportDate;
        private DateTime startDate;
        private DateTime endDate;
        private BookingController bookingController = new BookingController();
        private Collection<Booking> bookings;
        #endregion

        #region Properties
        public string ReportId
        {
            get { return reportId; }
            set { reportId = value; }
        }

        public DateTime ReportDate
        {
            get { return reportDate; }
            set { reportDate = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        #endregion


        #region Constructor
        public SummaryReportClass(DateTime startDate)
        {
            this.reportId = IDGenerator.GenerateWithPrefix("PHK");
            this.reportDate = DateTime.Today;
            this.startDate = startDate;
            this.endDate = startDate.AddDays(7);
            this.bookings = bookingController.AllBookings; // all the bookings are in this collection
        }
        #endregion

        #region Methods
        // variables
        public string summary = "";
        private int numBookings = 0;
        private decimal revenueForecast = 0;
        private decimal deposits = 0;
        private decimal average = 0;
        private CultureInfo currency = new CultureInfo("en-ZA"); // to print formatted amounts
        // get bookings within week from start date to display on richtext
        private void findBookings()
        {
            DateTime endDate = startDate.AddDays(7); // range of 1 week
            string days;


            foreach (Booking booking in bookings)
            {
                if (booking.SignInDate >= startDate && booking.SignOutDate <= endDate)
                {
                    if (booking.getDuration().Days == 1)
                        days = "day";
                    else
                        days = "days";

                    summary += booking.BookingID + "\t" + booking.getDuration().Days + " " + days + "\t\t\t" + string.Format(currency, "{0:C}", booking.getBookingAmount()) + "\t\t" + string.Format(currency, "{0:C}", booking.getBookingDeposit()) + "\n";
                    numBookings++;
                    revenueForecast += booking.getBookingAmount();
                    deposits += booking.getBookingDeposit();

                }
            }
            if (numBookings > 0)
            {
                average = revenueForecast / numBookings;
            }
        }



        public string printSummary()
        {
            findBookings();
            return summary;
        }

        public int printNumBookings()
        {
            numBookings = 0;
            findBookings();
            return numBookings;
        }

        public string printRevenue()
        {
            revenueForecast = 0;
            findBookings();
            return string.Format(currency, "{0:C}", revenueForecast);
        }

        public string printDeposits()
        {
            deposits = 0;
            findBookings();
            return string.Format(currency, "{0:C}", deposits);
        }

        public string printAverage()
        {
            average = 0;
            findBookings();
            return string.Format(currency, "{0:C}", average);

        }

        #endregion
    }
}



