using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_project.Business;
using Phumla_Kamnandi_project.Data.PhumlaKamnandiDatabaseDataSetTableAdapters;

namespace Phumla_Kamnandi_project.Data
{
    public class GuestDB : Database
    {
        #region Data Members
        string guestTable = "Guests";
        string sqlGuest = "SELECT * FROM Guests";
        private Collection<Guest> guests;
        #endregion

        #region Property Method
        public Collection<Guest> Guests
        {
            get { return guests; }
        }
        #endregion

        #region Constructor
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlGuest, guestTable);
            Add2Collection(guestTable);
        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dataSet;
        }

        private void Add2Collection(string guestTable)
        {
            DataRow myRow = null;
            Guest aGuest;

            foreach (DataRow guestData in dataSet.Tables[guestTable].Rows)
            {
                myRow = guestData;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest();
                    aGuest.GuestID = Convert.ToString(myRow["guestID"]).TrimEnd();
                    aGuest.Name = Convert.ToString(myRow["name"]).TrimEnd();
                    aGuest.Surname = Convert.ToString(myRow["surname"]).TrimEnd();
                    aGuest.PhoneNumber = Convert.ToString(myRow["phone"]).TrimEnd();
                    aGuest.Email = Convert.ToString(myRow["email"]).TrimEnd();
                    aGuest.Address = Convert.ToString(myRow["address"]).TrimEnd();
                    guests.Add(aGuest);
                }
            }
        }

        private void FillRow(DataRow aRow, Guest aGuest)
        {
            aRow["guestID"] = aGuest.GuestID;
            aRow["name"] = aGuest.Name;
            aRow["surname"] = aGuest.Surname;
            aRow["Phone"] = aGuest.PhoneNumber;
            aRow["email"] = aGuest.Email;
            aRow["address"] = aGuest.Address;
        }

        private int FindRow(Guest aGuest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnVal = -1;
            foreach (DataRow guestData in dataSet.Tables[table].Rows)
            {
                myRow = guestData;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aGuest.GuestID.Equals(Convert.ToString(dataSet.Tables[table].Rows[rowIndex]["guestID"])))
                    {
                        returnVal = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnVal;
        }
        #endregion

        #region Database Operations Crud
        public void DataSetChange(Guest aGuest, Database.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation)
            {
                case Database.DBOperation.Add:
                    aRow = dataSet.Tables[guestTable].NewRow();
                    FillRow(aRow, aGuest);
                    dataSet.Tables[guestTable].Rows.Add(aRow);
                    break;

                case Database.DBOperation.Edit:
                    dataSet.AcceptChanges();
                    int rowIndex = FindRow(aGuest, guestTable);
                    if (rowIndex != -1)
                    {
                        aRow = dataSet.Tables[guestTable].Rows[rowIndex];
                        FillRow(aRow, aGuest);
                    }
                    else
                    {
                        throw new Exception("Booking not found for update.");
                    }
                    break;

                case Database.DBOperation.Delete:
                    dataSet.AcceptChanges();
                    rowIndex = FindRow(aGuest, guestTable);
                    if (rowIndex != -1)
                    {
                        aRow = dataSet.Tables[guestTable].Rows[rowIndex];
                        aRow.Delete();
                    }
                    else
                    {
                        throw new Exception("Guest not found for update.");
                    }
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            dataAdapter.InsertCommand.Parameters.AddWithValue("@guestID", aGuest.GuestID);//Add the parameter to the Parameters collection.
            dataAdapter.InsertCommand.Parameters.AddWithValue("@name", aGuest.Name);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@surname", aGuest.Surname);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@phone", aGuest.PhoneNumber);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@email", aGuest.Email);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@address", aGuest.Address);
        }

        private void Build_UPDATE_Parameters(Guest aGuest)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Original_guestID", aGuest.GuestID);//Add the parameter to the Parameters collection.
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", aGuest.Name);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@surname", aGuest.Surname);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@phone", aGuest.PhoneNumber);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@email", aGuest.Email);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@address", aGuest.Address);
        }

        private void Build_DELETE_Parameters(Guest aGuest)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@Original_guestID", aGuest.GuestID);//Add the parameter to the Parameters collection.
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            dataAdapter.InsertCommand = new SqlCommand("INSERT INTO Guests (guestID, name, surname, phone, email, address) " + "VALUES (@guestID, @name, @surname, @phone, @email, @address)", connection);
            Build_INSERT_Parameters(aGuest);
        }

        private void Create_UPDATE_Command(Guest aGuest)
        {
            dataAdapter.UpdateCommand = new SqlCommand("UPDATE Guests SET name = @name, surname = @surname, phone = @phone, email = @email, address = @address " + "WHERE guestID = @Original_guestID", connection);
            Build_UPDATE_Parameters(aGuest);
        }

        private void Create_DELETE_Command(Guest aGuest)
        {
            dataAdapter.DeleteCommand = new SqlCommand("DELETE FROM Guests " + "WHERE guestID = @Original_guestID", connection);
            Build_DELETE_Parameters(aGuest);
        }

        public bool UpdateDataSource(Guest aGuest, Database.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case Database.DBOperation.Add:
                    Create_INSERT_Command(aGuest);
                    break;
                case Database.DBOperation.Edit:
                    Create_UPDATE_Command(aGuest);
                    break;
                case Database.DBOperation.Delete:
                    Create_DELETE_Command(aGuest);
                    break;

            }
            success = UpdateDataSource(sqlGuest, guestTable);
            return success;
        }
        #endregion
    }
}