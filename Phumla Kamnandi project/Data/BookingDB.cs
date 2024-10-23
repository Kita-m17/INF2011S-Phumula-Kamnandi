using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_project.Business;

namespace Phumla_Kamnandi_project.Data
{
    public class BookingDB:Database
    {
        #region 
        private Collection<Booking> bookings = new Collection<Booking>();
        private string bookingTable = "Bookings";
        private string sqlBooking = "SELECT * FROM Bookings";
        #endregion

        #region Properties
        public Collection<Booking> Booking {
            get { return bookings; }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlBooking, bookingTable);
            Add2Collection(bookingTable);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dataSet;
        }
        private void Add2Collection(string bookingTable)
        {
            DataRow myRow = null;
            Booking aBooking;

            foreach (DataRow bookingData in dataSet.Tables[bookingTable].Rows)
            {
                if (dataSet.Tables[bookingTable].Rows.Count == 0)
                {
                    Console.WriteLine("No rows found in the dataset for table: " + bookingTable);
                    return;
                }

                myRow = bookingData;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aBooking = new Booking();
                    aBooking.BookingID = Convert.ToString(myRow["bookingID"]).TrimEnd();
                    aBooking.GuestID = Convert.ToString(myRow["guestID"]).TrimEnd();
                    aBooking.HotelID = Convert.ToString(myRow["hotelID"]).TrimEnd();
                    aBooking.SignInDate = Convert.ToDateTime(myRow["signInDate"]);
                    aBooking.SignOutDate = Convert.ToDateTime(myRow["signOutDate"]);
                    aBooking.NumRooms = Convert.ToInt32(myRow["numRooms"]);
                    aBooking.NumChildren = Convert.ToInt32(myRow["numChildren"]);
                    aBooking.RoomID = Convert.ToString(myRow["roomID"]).TrimEnd();
                    aBooking.NumAdults = Convert.ToInt32(myRow["numAdults"]);
                    
                    bookings.Add(aBooking);
                }
            }
        }

        private void FillRow(DataRow aRow, Booking aBooking)
        {
            aRow["bookingID"] = aBooking.BookingID;
            aRow["guestID"] = aBooking.GuestID;
            aRow["hotelID"] = aBooking.HotelID;
            aRow["signInDate"] = aBooking.SignInDate;
            aRow["signOutDate"] = aBooking.SignOutDate;
            aRow["roomID"] = aBooking.RoomID;
            aRow["numAdults"] = aBooking.NumAdults;
            aRow["numChildren"] = aBooking.NumChildren;
            aRow["numRooms"] = aBooking.NumRooms;
        }

        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnVal = -1;

            foreach(DataRow bookingData in dataSet.Tables[table].Rows)
            {
                myRow = bookingData;
                if(myRow.RowState != DataRowState.Deleted)
                {
                    if(aBooking.BookingID.Equals(Convert.ToString(dataSet.Tables[table].Rows[rowIndex]["bookingID"])))
                    {
                        returnVal = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnVal;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Booking aBooking, Database.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation) {
                case Database.DBOperation.Add:
                    aRow = dataSet.Tables[bookingTable].NewRow();
                    FillRow(aRow, aBooking);
                    dataSet.Tables[bookingTable].Rows.Add(aRow);
                    break;

                case Database.DBOperation.Edit:
                    dataSet.AcceptChanges();
                    int rowIndex = FindRow(aBooking, bookingTable);
                    if(rowIndex != -1)
                    {
                        aRow = dataSet.Tables[bookingTable].Rows[rowIndex];
                        FillRow(aRow, aBooking);
                    }
                    else
                    {
                        throw new Exception("Booking not found for update.");
                    }
                    break;

                case Database.DBOperation.Delete:
                    dataSet.AcceptChanges();

                    rowIndex = FindRow(aBooking, bookingTable);
                    if (rowIndex != -1)
                    {
                        aRow = dataSet.Tables[bookingTable].Rows[rowIndex];
                        aRow.Delete();
                    }
                    else
                    {
                        throw new Exception("Booking not found for deletion.");
                    }
                    break;
            }
            bool success = UpdateDataSource(aBooking, operation);
            if (!success){
                throw new Exception("Failed to update the database.");
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking aBooking)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            dataAdapter.InsertCommand.Parameters.AddWithValue("@bookingID", aBooking.BookingID);//Add the parameter to the Parameters collection.
            dataAdapter.InsertCommand.Parameters.AddWithValue("@guestID", aBooking.GuestID);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@hotelID", aBooking.HotelID);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@signInDate", aBooking.SignInDate);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@signOutDate", aBooking.SignOutDate);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@numRooms", aBooking.NumRooms);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@numChildren", aBooking.NumChildren);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@roomID", aBooking.RoomID);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@numAdults", aBooking.NumAdults);
        }

        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Original_bookingID", aBooking.BookingID);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@guestID", aBooking.GuestID);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@hotelID", aBooking.HotelID);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@signInDate", aBooking.SignInDate);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@signOutDate", aBooking.SignOutDate);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@numRooms", aBooking.NumRooms);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@numChildren", aBooking.NumChildren);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@roomID", aBooking.RoomID);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@numAdults", aBooking.NumAdults);
        }

        private void Build_DELETE_Parameters(Booking aBooking)
        {
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@Original_bookingID", aBooking.BookingID);
        }

        private void CREATE_INSERT_COMMAND(Booking aBooking)
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Bookings (bookingID, guestID, hotelID, signInDate, signOutDate, numRooms, numChildren, roomID, numAdults) " + "VALUES (@bookingID, @guestID, @hotelID, @signInDate, @signOutDate,  @numRooms,  @numChildren, @roomID, @numAdults)", connection);
            Build_INSERT_Parameters(aBooking); 
        }

        private void CREATE_UPDATE_COMMAND(Booking aBooking)
        {
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE Bookings SET signInDate = @signInDate, signOutDate = @signOutDate, numRooms = @numRooms, numChildren = @numChildren, roomID = @roomID, numAdults = @numAdults " + "WHERE bookingID = @Original_bookingID", connection);
            Build_UPDATE_Parameters(aBooking);
        }

        private void CREATE_DELETE_COMMAND(Booking aBooking)
        {
            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM Bookings " + "WHERE bookingID = @Original_bookingID", connection);
            Build_DELETE_Parameters(aBooking);
        }

        public bool UpdateDataSource(Booking aBooking, Database.DBOperation operation)
        {
            bool success = true;
            switch (operation) {
                case Database.DBOperation.Add:
                    CREATE_INSERT_COMMAND(aBooking);
                    break;
                case Database.DBOperation.Edit:
                    CREATE_UPDATE_COMMAND(aBooking);
                    break;
                case Database.DBOperation.Delete:
                    CREATE_DELETE_COMMAND(aBooking);
                    break;

            }

            //update database based on the operation performed
            success = UpdateDataSource(sqlBooking, bookingTable);
            return success;
        }
        #endregion
    }
}