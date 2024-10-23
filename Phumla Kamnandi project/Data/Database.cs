using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamnandi_project.Properties;
using System.Windows.Forms;

namespace Phumla_Kamnandi_project.Data
{
    public class Database
    {
        #region Data Members
        //private string connectionString = Settings.Default.PhumlaKamnandiDatabaseConnectionString;
        //this is a local database, please add the connection string of the database on your local pc's
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Nikita Martin\\OneDrive - University of Cape Town\\inf2011s\\Project\\Phumla Kamnandi project\\Data\\PhumlaKamnandiDatabase.mdf\";Integrated Security=True";
        protected SqlConnection connection;
        protected DataSet dataSet;
        protected SqlDataAdapter dataAdapter;

        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2,
        }
        #endregion

        #region Constructor
        public Database()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                dataSet = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error. Connection Unsuccessful.");
                return;
            }
        }
        #endregion

        #region Methods
        public void FillDataSet(string sqlString, string table)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(sqlString, connection);
                connection.Open();
                dataAdapter.Fill(dataSet, table);
                connection.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                connection.Open();
                dataAdapter.Update(dataSet, table);
                connection.Close();
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                //Message
                success = false;
            }
            finally
            {
                //connection.Close();
            }
            return success;
        }
        #endregion 
    }
}