using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    public class Person
    {
        #region Data members
        private string name;
        private string surname;
        private string phoneNumber;
        private string email;
        private string address;
        #endregion
        #region Properties
        public string Name { 
            get{ return name; } 
            set{name = value;}
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email { 
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Constructors
        public Person(string name, string surname, string phone, string email)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phone;
            this.email = email;
        }
        #endregion
    }
}
