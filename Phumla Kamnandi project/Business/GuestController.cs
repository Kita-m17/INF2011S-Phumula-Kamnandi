using Phumla_Kamnandi_project.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project.Business
{
    public class GuestController
    {
        GuestDB guestDB;
        Collection<Guest> guests;

        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }

        public GuestController() { 
            guestDB = new GuestDB();
            guests = guestDB.Guests;
        }

        #region Database Communication.
        public void DataMaintenance(Guest aGuest, Database.DBOperation operation)
        {
            //perform a given database operation to the dataset in memory; 
            int index = 0;
            guestDB.DataSetChange(aGuest, operation);
            switch (operation)
            {
                case Database.DBOperation.Add:
                    guests.Add(aGuest);
                    break;
                case Database.DBOperation.Edit:
                    index = FindIndex(aGuest);
                    guests[index] = aGuest;
                    break;
                case Database.DBOperation.Delete:
                    index = FindIndex(aGuest);
                    guests.RemoveAt(index);
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Guest guest, Database.DBOperation operation)
        {
            //***call the guestDB method that will commit the changes to the database
            return guestDB.UpdateDataSource(guest, operation);
        }
        #endregion
        
        #region Search Method
        public Guest Find(string ID)
        {
            int index = 0;
            bool found = false;
            if (guests[index].GuestID.Equals(ID))
            {
                found = true;
            }
            while (!(found) && (index < guests.Count - 1))
            {
                index++;
                found = (guests[index].GuestID == ID);
            }
            if (found)
            {
                return guests[index];
            }
            else
            {
                return null;
            }
        }

        public int FindIndex(Guest aGuest)
        {
            int counter = 0;
            bool found = false;
            found = (aGuest.GuestID.Equals(guests[counter].GuestID));
            while (!found && (counter != guests.Count))
            {
                counter = counter + 1;
                found = (aGuest.GuestID.Equals(guests[counter].GuestID));
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
    }
}
