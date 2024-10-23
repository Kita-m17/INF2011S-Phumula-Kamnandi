using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_project.Data;
using Phumla_Kamnandi_project.Business;
using Phumla_Kamnandi_project.Properties;
using System.Data.SqlClient;
using System.Data;
using Phumla_Kamnandi_project.Data;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project.Business
{
    public class HotelController:Database
    {
        #region Data members
        private static Collection<Hotel> hotels;
        private string hotelTable = "Hotels";
        private string sqlHotel = "SELECT * FROM Hotels";
        #endregion

        #region Construction
        public HotelController() {
            hotels = new Collection<Hotel>();
            FillDataSet(sqlHotel, hotelTable);
            Add2Collection(hotelTable);
        }
        #endregion

        #region properties
        public Collection<Hotel> AllHotels
        {
            get { return hotels; }
        }
        #endregion

        #region Methods
        private void Add2Collection(string hotelTable)
        {
            DataRow myRow = null;
            Hotel aHotel;

            foreach (DataRow hotelData in dataSet.Tables[hotelTable].Rows)
            {
                if (dataSet.Tables[hotelTable].Rows.Count == 0)
                {
                    MessageBox.Show("No rows found in the dataset for table: " + hotelTable);
                    return;
                }

                myRow = hotelData;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aHotel = new Hotel();
                    aHotel.HotelID = Convert.ToString(myRow["hotelID"]).TrimEnd();
                    aHotel.HotelName = Convert.ToString(myRow["hotelName"]).TrimEnd();
                    aHotel.NumRooms = Convert.ToInt32(myRow["noOfRooms"]);
                    aHotel.Location = Convert.ToString(myRow["location"]).TrimEnd();
                    aHotel.AvailableRooms = Convert.ToInt32(myRow["availableRooms"]);
                    aHotel.Facilities = Convert.ToString(myRow["facilities"]).TrimEnd();
                    aHotel.Rate = Convert.ToDecimal(myRow["rate"]);

                    hotels.Add(aHotel);
                }
            }
        }
        #endregion
    }
}