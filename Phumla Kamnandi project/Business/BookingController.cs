using Phumla_Kamnandi_project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class BookingController
    {
        #region Data Members
        BookingDB bookingDB;
        Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.Booking;
        }
        #endregion

        #region DataBase Communication
        public void DataMaintenance(Booking booking, Database.DBOperation operation)
        {
            int index = 0;
            bookingDB.DataSetChange(booking, operation);
            switch (operation)
            {
                case Database.DBOperation.Add:
                    bookings.Add(booking);
                    break;
                case Database.DBOperation.Edit:
                    index = FindIndex(booking);
                    bookings[index] = booking;
                    break;
                case Database.DBOperation.Delete:
                    index = FindIndex(booking);
                    bookings.RemoveAt(index);
                    break;
            }
        }

        public bool FinalizeChanges(Booking booking, Database.DBOperation operation)
        {
            return bookingDB.UpdateDataSource(booking, operation);
        }
        #endregion

        #region Search Method
        public Booking Find(string bookingID)
        {
            int index = 0;
            bool found = false;

            if (bookings[index].BookingID.Equals(bookingID))
            {
                found = true;
            }
            while (!(found) && (index < bookings.Count - 1))
            {
                index++;
                found = (bookings[index].BookingID.Equals(bookingID));
            }
            if (found)
            {
                return bookings[index];
            }
            else
            {
                return null;
            }
        }

        public int FindIndex(Booking booking)
        {
            int counter = 0;
            bool found = false;
            found = (booking.BookingID.Equals(bookings[counter].BookingID));
            while (!found && (counter != bookings.Count))
            {
                counter = counter + 1;
                found = (booking.BookingID.Equals(bookings[counter].BookingID));
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region Availability Check
        public bool AreRoomsAvailable(string hotelID, DateTime signInDate, DateTime signOutDate, int numRoomsRequested)
        {
            int totalRooms = 0; // Total rooms the hotel has
            int bookedRooms = 0; // Number of rooms already booked

            // Get the hotel from the hotel controller
            HotelController hotelController = new HotelController();
            
            Hotel currHotel = new Hotel();
            foreach( Hotel hotel in hotelController.AllHotels)
            {
                if (hotel.HotelID == hotelID)
                {
                    totalRooms = hotel.NumRooms;
                    break;
                }
            }

            if(totalRooms == 0)
            {
                throw new Exception("Hotel not found.");
            }

            // Loop through all bookings to count how many rooms are booked during the given date range
            foreach (Booking booking in bookings)
            {
                if (booking.HotelID == hotelID)
                {

                    bool overlap = (booking.SignInDate <= signOutDate && booking.SignOutDate >= signInDate);
                    // Check if booking overlaps with the requested date range
                    if (overlap)
                    {
                        bookedRooms += booking.NumRooms;
                    }
                }
            }

            // Compare booked rooms with total rooms in the hotel
            if (bookedRooms + numRoomsRequested <= totalRooms)
            {
                return true;// enough rooms available
            }
            return false;// no rooms are available
        }

        // Method to prompt the user to choose alternative dates if rooms are unavailable
        public string CheckRoomAvailabilityAndPrompt(string hotelID, DateTime signInDate, DateTime signOutDate, int numRoomsRequested)
        {
            if (!AreRoomsAvailable(hotelID, signInDate, signOutDate, numRoomsRequested))
            {
                return "Sorry, no rooms are available for the selected dates. Please choose another date range.";
            }

            return "Rooms are available! You can proceed with the booking.";
        }

        public int getAvailableRooms(string hotelID, DateTime signInDate, DateTime signOutDate)
        {
            int totalRooms = 0; // Total rooms the hotel has
            int bookedRooms = 0; // Number of rooms already booked

            // Get the hotel from the hotel controller
            HotelController hotelController = new HotelController();

            foreach (Hotel hotel in hotelController.AllHotels)
            {
                if (hotel.HotelID == hotelID)
                {
                    totalRooms = hotel.NumRooms;
                    break;
                }
            }

            if (totalRooms == 0)
            {
                throw new Exception("Hotel not found.");
            }

            // Loop through all bookings to count how many rooms are booked during the given date range
            foreach (Booking booking in bookings)
            {
                if (booking.HotelID == hotelID)
                {

                    bool overlap = (booking.SignInDate <= signOutDate && booking.SignOutDate >= signInDate);
                    // Check if booking overlaps with the requested date range
                    if (overlap)
                    {
                        bookedRooms += booking.NumRooms;
                    }
                }
            }

            return totalRooms- bookedRooms;
        }
        #endregion
    }
}