using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Data
{
    public class Hotel
    {
        #region Data Members
        private string hotelName;
        private int numRooms;
        private string hotelID;
        private string details;
        private string location;
        private string facilities;
        private bool hasPool;
        private bool hasGamesRoom;
        private static Collection<Room> rooms;
        #endregion

        #region Properties
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

        public string HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public string Facilities
        {
            get { return facilities; }
            set { facilities = value; }
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

        public bool HasPool {
            get { return hasPool;}
            set { hasPool = value;}
        }

        public bool HasGamesRoom
        {
            get { return hasGamesRoom; }
            set { hasGamesRoom = value; }
        }
        #endregion

        #region Constructors    
        public Hotel(string hotelID, string hotelName, string location, string details, string facilities, int numRooms)
        {
            this.hotelID = hotelID;
            this.hotelName = hotelName;
            this.location = location;
            this.numRooms = numRooms;
            this.details = details;
            this.facilities = facilities;
            Hotel.rooms = new Collection<Room>();
            this.hasPool = false;
            this.hasGamesRoom = false;
        }
        #endregion

        #region Methods
        /*
         * Method that checks all the available rooms within a given hotel
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

        /*
         * 
         */
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
    }
 }
