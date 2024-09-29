using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    internal class Payment
    {
        #region Data Members
        //instance variables
        private string paymentID;
        private DateTime paymentDate;
        private double paymentAmount;
        private string paymentMethod;
        #endregion

        #region Properties
        //getters and setters
        public string PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        public double PaymentAmount
        {   get { return paymentAmount; } 
            set { paymentAmount = value; } 
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        #endregion

        #region Constructors
        public Payment(string paymentID, DateTime paymentDate,  double paymentAmount, string paymentMethod)
        {
            this.paymentID = paymentID;
            this.paymentDate = paymentDate;
            this.paymentAmount = paymentAmount;
            this.paymentMethod = paymentMethod;
        }

        #endregion

        #region Methods


        #endregion
    }
}
