﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    internal class Payment
    {
        #region Data Members
        private string paymentID;
        private DateTime paymentDate;
        private double paymentAmount;
        private string paymentMethod;
        #endregion

        #region Properties
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

        #region Constructor
        public Payment(string paymentID, DateTime paymentDate,  double paymentAmount, string paymentMethod)
        {
            this.paymentID = paymentID;
            this.paymentDate = paymentDate;
            this.paymentAmount = paymentAmount;
            this.paymentMethod = paymentMethod;
        }
        #endregion

        #region Methods
        public void processPayment() //add payment to database
        {
        
        }
        
        public void refundPayment() //remove database from databas or change change amount to negative
        {
        
        }
        
        public void verifyPayment() // Verify the payment.
        {
          
        }
        #endregion
    }
}
