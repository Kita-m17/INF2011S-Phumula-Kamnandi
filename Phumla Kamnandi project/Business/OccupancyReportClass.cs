using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Phumla_Kamnandi_project.Business
{
    internal class OccupancyReportClass
    {
        #region Data Members
        private string reportId;
        private DateTime reportDate;
        //private string generatedBy;
        private DateTime startDate;
        private DateTime endDate;
        private BookingController bookingController = new BookingController();
        private Collection<Booking> bookings;
        private int[] grid = new int[7];
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

        #region Constructors
        public OccupancyReportClass(DateTime startDate)
        {
            this.reportId = IDGenerator.GenerateWithPrefix("PHK");
            this.reportDate = DateTime.Today;
            this.startDate = startDate;
            this.bookings = bookingController.AllBookings; // put all bookings in database into this.bookings
            endDate = startDate.AddDays(7);
        }
        #endregion

        #region Methods

        //initialize all days to 0 
        private void initializeGrid()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = 0;
            }
        }

        //get number of rooms, put them in grid
        private void populateGrid()
        {
            initializeGrid();

            for (int i = 0; i < grid.Length; i++)
            {
                DateTime currentDate = startDate.AddDays(i); // the day we want to check rooms for
                foreach (Booking booking in bookings)
                {
                    if (currentDate <= booking.SignOutDate && currentDate >= booking.SignInDate)
                    {
                        grid[i] += booking.NumRooms; // add number of rooms this position of grid
                    }
                }
            }
        }

        public void colourInBlocks(PictureBox[,] blocks)
        {
            populateGrid(); // get all grid number of rooms

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i]; j++)
                {
                    blocks[i, j].BackColor = Color.Blue;  //colour in the gridBlock
                }
            }
        }


        #endregion

    }
}



