using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Receptionist : Person
    {
        #region Data Members
        private string receptionistID;
        private string loginPassword;
        private DateTime dateEmployed;
        private decimal salary;
        #endregion

        #region Properties
        public string ReceptionistID {  
            get { return receptionistID; } 
            set { receptionistID = value; }
        }

        public string LoginPassword { 
            get { return loginPassword; }
            set { loginPassword = value; }
        }

        public DateTime EmploymentDate { 
            get { return dateEmployed; }
            set { dateEmployed = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion

        #region Constructors
        public Receptionist(string receptionistID, string loginPassword, DateTime dateEmployed, decimal salary, string name, string surname, string phone, string email) : base(name, surname, phone, email)
        {
            this.receptionistID = receptionistID;
            this.loginPassword = loginPassword;
            this.dateEmployed = dateEmployed;
            this.salary = salary;
        }
        #endregion

        #region Methods
        public decimal Payment()
        {
            return salary ;
        }
        #endregion
    }
}
