using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Guest:Person
    {
        #region Data members
        private string guessID;
        #endregion

        #region Properties
        public string GuestID
        {
            get { return guessID; }
            set { guessID = value; }
        }
        #endregion

        #region Constructor
        public Guest(string guessID, string name, string surname, string phone, string email):base(name, surname, phone, email)
        {
            this.guessID = guessID;
        }
        #endregion

        #region Methods

        #endregion

    }
}
