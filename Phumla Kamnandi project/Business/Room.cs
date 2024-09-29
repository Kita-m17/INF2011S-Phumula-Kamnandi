using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Room
    {
        #region Data Members
        private string roomID;
        private decimal rate;
        private string details;
        private bool availability;
        private int capacity; //number of people it can hold (doesnt matter how) 
        private string hotelID;
        private List<Booking> bookings;
        #endregion

        #region Properties
        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string RoomDetails
        {
            get { return details; }
            set { details = value; }
        }

        public bool RoomAvailability
        {
            get { return availability; }
            set { availability = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public List<Booking> Bookings
        {
            get { return bookings; }
        }
        #endregion region

        #region Constructors
        public Room(string roomID, decimal rate, string details, string hotelID, bool availability, int capacity)
        {
            this.roomID = roomID;
            this.rate = rate;
            this.details = details;
            this.availability = availability;
            this.capacity = capacity;
            this.hotelID = hotelID;
            this.bookings = new List<Booking>();
        }
        #endregion

        #region Methods
        /*
         * reserve a room
         */
        public void reserveRoom(string guestID, DateTime signInDate, DateTime signOutDate)
        {
            availability = false;
            bookings.Add(new Booking(guestID, hotelID, signInDate, signOutDate, roomID));
        }

        /*
         * Method that checks if a room is available for booking within a specific time period
         */
        public bool checkRoomAvailability(DateTime signInDate, DateTime signOutDate)
        {
            foreach (Booking booking in bookings)
            {
                //check if the sign-in date of a new booking falls within an existing booking period
                bool check1 = (signInDate >= booking.SignInDate && signInDate < booking.SignOutDate);
                //check if the sign-out date of the new booking falls within an existing booking period
                bool check2 = (signOutDate > booking.SignInDate && signOutDate <= booking.SignOutDate);
                //checks if the new booking completely overlaps an existing booking
                bool check3 = (signInDate < booking.SignInDate && signOutDate > booking.SignOutDate);
                if (check1 || check2 || check3)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}
