using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_project.Business
{
    internal class CreditCard
    {
        #region Data Members
        private string creditCardNumber;
        private DateTime expiryDate;
        private string holderName;
        private string cvvNumber;
        #endregion

        #region Properties
        public string CreditCardNumber
        { 
            get { return creditCardNumber; }
            set { creditCardNumber = value; } 
        }

        public DateTime ExpiryDate
        {   get { return expiryDate; } 
            set { expiryDate = value; } 
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public string CvvNumber
        {
            get { return cvvNumber; }
            set { cvvNumber = value; }
        }
        #endregion

        #region Constructor
        public CreditCard(string creditCardNumber,  string holderName, string cvvNumber, DateTime expiryDate)
        {
            this.creditCardNumber = creditCardNumber;
            this.holderName = holderName;
            this.cvvNumber = cvvNumber;
            this.expiryDate = expiryDate;
        }
        #endregion

        #region Methods
        public string verifyCreditCard(string creditCardNumber)
        {
            // Check that the credit card number is 16 digits.
            if (creditCardNumber.Length != 16)
            {
                return "Credit card is invalid: Length is not 16 digits.";
            }

            // Check that the credit card contains only numbers.
            foreach (char c in creditCardNumber)
            {
                if (!char.IsDigit(c))
                {
                    return "Credit card is invalid: Contains non-numeric characters.";
                }
            }
            return "Credit card is valid.";
        }
        #endregion
    }
}