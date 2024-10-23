using Phumla_Kamnandi_project.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Hotel
    {
        #region Data Members
        private string hotelName;
        private int numRooms;
        private string hotelID;
        private int availRooms;
        private string location;
        private string facilities;
        private decimal rate;
        private bool hasPool;
        private bool hasGamesRoom;
        private Season season;
        private static Collection<Room> rooms;
        #endregion

        #region Properties

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }
        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        public int NumRooms
        {
            get { return numRooms; }
            set { numRooms = value; }
        }

        public int AvailableRooms { 
            set { availRooms = value; }
            get { return availRooms; }
        }

        public string Facilities
        {
            get { return facilities; }
            set { facilities = value; }
        }

        public decimal Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Collection<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public bool HasPool
        {
            get { return hasPool; }
            set { hasPool = value; }
        }

        public bool HasGamesRoom
        {
            get { return hasGamesRoom; }
            set { hasGamesRoom = value; }
        }

        public enum Season { 
            LowSeason = 0,
            MidSeason = 1,
            HighSeason = 2,
        }
        #endregion

        #region Constructors    
        public Hotel(string hotelID, string hotelName, string location, string facilities, int numRooms, int availableRooms, decimal rate)
        {
            this.hotelID = hotelID;
            this.hotelName = hotelName;
            this.location = location;
            this.facilities = facilities;
            //Hotel.rooms = new Collection<Room>();
            this.numRooms = numRooms;
            this.availRooms = availableRooms;
            this.rate = rate;
        }

        public Hotel() {
            hotelID = "";
            hotelName = "";
            location = "";
            facilities = "";
            numRooms = 0;
            availRooms = 0;
        }
        #endregion

        #region Methods
        /*
         * Method that checks all the available rooms within a given hotel.
        */
        public Collection<Room> availableRooms(DateTime signInDate, DateTime signOutDate)
        {
            Collection<Room> availableRooms = new Collection<Room>();
            foreach (Room room in Hotel.rooms)
            {
                if (room.checkRoomAvailability(signInDate, signOutDate) == true)
                {
                    availableRooms.Add(room);
                }
            }
            return availableRooms;
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public static Room FindRoom(string roomID)
        {
            foreach (Room room in Hotel.rooms)
            {
                if (room.RoomID == roomID)
                {
                    return room;
                }
            }
            return null;
            #endregion
        }

        public void addFacilities()
        {
            if (hasPool && !hasGamesRoom)
            {
                this.facilities += "Has a Pool.";
            }
            else if (!hasPool && hasGamesRoom)
            {
                this.facilities += "Has a Games room.";
            }
            else
            {
                this.facilities += "Has a Pool and a Games room.";
            }
        }

        public Season getSeason(DateTime date) {

            if (date.Month == 12)
            {

                if (date.Day >= 1 && date.Day <= 7)
                {
                    return Season.LowSeason;
                }
                else if (date.Day >= 8 && date.Day <= 15)
                {
                    return Season.MidSeason;
                }
                else
                {
                    return Season.HighSeason;
                }
            }
            else
            {
                return Season.LowSeason;
            }
        }

        public decimal getRate(DateTime signInDate, DateTime signOutDate)
        {
            decimal totalRate = 0;
            TimeSpan duration = signOutDate.Subtract(signInDate);

            for (int i = 0; i < duration.Days; i++)
            {
                DateTime currentDate = signInDate.AddDays(i);
                Season currentSeason = getSeason(currentDate);

                switch (currentSeason)
                {
                    case Season.LowSeason:
                        totalRate += 550;
                        break;
                    case Season.MidSeason:
                        totalRate += 750;
                        break;
                    case Season.HighSeason:
                        totalRate += 995;
                        break;
                }
            }
            return totalRate;
        }
    }
}