using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Guest:Person
    {
        #region Data Members
        private string guestID;
        #endregion

        #region Properties
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        #endregion

        #region Constructor
        public Guest(string guestID, string name, string surname, string phone, string email, string address) : base(name, surname, phone, email, address)
        {
            this.guestID = guestID;
        }

        public Guest() :base()
        { }
        #endregion

    }
}