using Phumla_Kamnandi_project.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Booking
    {
        #region Data Members
        private string bookingID;
        private DateTime signInDate;
        private DateTime signOutDate;
        private string roomID;
        private string hotelID;
        private string guestID;
        private int numChildren;
        private int numAdults;
        private int numRooms;
        #endregion

        #region Properties
        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public DateTime SignInDate
        {
            get { return signInDate; }
            set { signInDate = value; }
        }

        public DateTime SignOutDate
        {
            get { return signOutDate; }
            set { signOutDate = value; }
        }

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string GuessID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public int NumChildren
        {
            get { return numChildren; }
            set { numChildren = value; }
        }

        public int NumAdults
        {
            get { return numAdults; }
            set { numAdults = value; }
        }

        public int NumRooms
        {
            get { return numRooms; }
        }
        #endregion

        #region Constructors
        public Booking(string guestID, string hotelID, DateTime signInDate, DateTime signOutDate, string roomNum)
        {
            this.bookingID = IDGenerator.GenerateWithPrefix("BID");
            this.guestID = guestID;
            this.hotelID = hotelID;
            this.signInDate = signInDate;
            this.signOutDate = signOutDate;
            this.roomID = roomNum;
            this.numChildren = 0;
            this.numAdults = 1;

        }
        #endregion

        #region Methods
        /*
         * Method that reserves a room if its existing and available 
         */
        public void getRoom(string roomID, DateTime signInDate, DateTime signOutDate)
        {
            Room room = Hotel.FindRoom(roomID);
            if (room != null)
            {
                room.reserveRoom(guestID, signInDate, signOutDate);
            }
        }
        #endregion
    }
}
