using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*  SQL Script to create the Receptionists table in the database:
    INSERT INTO [dbo].[Receptionists] 
    ([ID], [empID], [name], [surname], [phone], [email], [dateEmployed], [salary], [password])
    VALUES 
        ('R001', 'EMP001', 'Alice', 'Mthembu', '0712345678', 'alice.mthembu@phumulaKamandi.co.za', '2023-05-01', 45000.00, 'password123'),  -- Hashed: 'password123'
        ('R002', 'EMP002', 'Thabo', 'Nkosi', '0734567890', 'thabo.nkosi@phumulaKamandi.co.za', '2022-11-15', 47000.00, 'mypassword456'),  -- Hashed: 'mypassword456'
        ('R003', 'EMP003', 'Sipho', 'Dlamini', '0745678901', 'sipho.dlamini@phumulaKamandi.co.za', '2024-01-10', 48000.00, 'securepass789'),  -- Hashed: 'securepass789'
        ('R004', 'EMP004', 'Nomsa', 'Hlongwane', '0756789012', 'nomsa.hlongwane@phumulaKamandi.co.za', '2023-07-25', 46000.00, 'password@1234'),  -- Hashed: 'password@1234'
        ('R005', 'EMP005', 'Zanele', 'Khumalo', '0767890123', 'zanele.khumalo@phumulaKamandi.co.za', '2022-09-20', 49000.00, 'zanele2024!');  -- Hashed: 'zanele2024!'
*/

namespace Phumla_Kamnandi_project.Business
{
    /// <summary>
    /// Represents a Receptionist, inheriting from the Person class.
    /// Manages receptionist-specific data such as ID, password, employment date, and salary.
    /// </summary>
    public class Receptionist : Person
    {
        #region Data Members
        private string receptionistID;
        private string loginPassword;
        private DateTime dateEmployed;
        private decimal salary;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique identifier for the receptionist.
        /// </summary
        public string ReceptionistID {  
            get { return receptionistID; } 
            set { receptionistID = value; }
        }

        /// <summary>
        /// Gets or sets the hashed login password for the receptionist.
        /// The password is automatically hashed when set.
        /// </summary>
        public string LoginPassword { 
            get { return loginPassword; }
            set { loginPassword = LoginController.HashPassword(value); }
        }

        /// <summary>
        /// Gets or sets the employment date of the receptionist.
        /// </summary>
        public DateTime EmploymentDate { 
            get { return dateEmployed; }
            set { dateEmployed = value; }
        }

        /// <summary>
        /// Gets or sets the salary of the receptionist.
        /// </summary>
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Receptionist"/> class.
        /// </summary>
        /// <param name="receptionistID">The unique identifier of the receptionist.</param>
        /// <param name="loginPassword">The login password for the receptionist (this will be hashed).</param>
        /// <param name="dateEmployed">The date the receptionist was employed.</param>
        /// <param name="salary">The salary of the receptionist.</param>
        /// <param name="name">The first name of the receptionist.</param>
        /// <param name="surname">The surname of the receptionist.</param>
        /// <param name="phone">The phone number of the receptionist.</param>
        /// <param name="email">The email address of the receptionist.</param>
        public Receptionist(string receptionistID, string loginPassword, DateTime dateEmployed, decimal salary, string name, string surname, string phone, string email) : base(name, surname, phone, email)
        {
            this.receptionistID = receptionistID;
            this.LoginPassword = loginPassword;
            this.dateEmployed = dateEmployed;
            this.salary = salary;
        }
        #endregion

        #region Methods
        public decimal Payment()
        {
            return salary;
        }

        /// <summary>
        /// Validates the input password by comparing it with the stored hashed password.
        /// </summary>
        /// <param name="inputPassword">The password input by the user.</param>
        /// <returns>True if the input password matches the stored hashed password; otherwise, false.</returns>
        public bool ValidatePassword(string inputPassword)
        {
            string inputPasswordHash = LoginController.HashPassword(inputPassword);
            return inputPasswordHash == loginPassword;
        }
        #endregion
    }
}