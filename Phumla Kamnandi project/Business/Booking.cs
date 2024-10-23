using Phumla_Kamnandi_project.Business;
using Phumla_Kamnandi_project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private HotelController hotelController = new HotelController();
        private GuestController guestController = new GuestController();
        private Collection<Guest> guests;
        private Collection<Hotel> hotels;
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

        public string GuestID
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
            set { numRooms = value; }
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
            this.numChildren = 0;
            this.numAdults = 1;
            this.numRooms = 1;
            this.roomID = roomNum;
            this.hotels = hotelController.AllHotels;
            this.guests = guestController.AllGuests;
        }

        public Booking()
        {
            this.bookingID = IDGenerator.GenerateWithPrefix("BID");
            this.guestController = new GuestController();
            this.hotels = hotelController.AllHotels;
            this.guests = guestController.AllGuests;
        }
        #endregion

        #region Methods
        public void reserveRooms(string roomID, DateTime signInDate, DateTime signOutDate)
        {
            Room room = Hotel.FindRoom(roomID);
            if (room != null)
            {
                room.reserveRoom(guestID, signInDate, signOutDate);
            }
            else
            {
                Console.WriteLine("Room " + roomID + " is not found.");
            }
        }

        public TimeSpan getDuration()
        {
            TimeSpan duration = signOutDate.Subtract(signInDate);
            return duration;
        }

        public Hotel getHotel()
        {
            foreach (Hotel hotel in hotels)
            {
                if (hotel.HotelID.Equals(this.HotelID))
                {
                    return hotel;
                }
            }
            return null;
        }

        public decimal getBookingAmount()
        {
            int bookingDuration = this.getDuration().Days;
            Hotel hotel = getHotel();
            return bookingDuration * hotel.getRate(signInDate, signOutDate);
        }

        public decimal getBookingDeposit()
        {
            decimal discount = (decimal)10 / 100;
            return getBookingAmount() * discount;
        }

        public Guest getGuest()
        {
            foreach(Guest guest in guestController.AllGuests)
            {
                if (guest.GuestID == guestID)
                {
                    return guest;
                }
            }
            return null;
        }
        #endregion
    }
}