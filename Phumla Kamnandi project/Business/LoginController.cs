using Phumla_Kamnandi_project.Properties;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Phumla_Kamnandi_project.Business
{
    /// <summary>
    /// The LoginController class is responsible for managing user login functionality
    /// within the Phumla Kamnandi project. It interacts with the database to verify user credentials.
    /// </summary>
    internal class LoginController
    {
        private Receptionist receptionist;
        #region Methods
        /// <summary>
        /// Verifies the user's login credentials against the database.
        /// </summary>
        /// <param name="userName">The email address of the user attempting to log in.</param>
        /// <param name="password">The password entered by the user.</param>
        /// <returns>
        /// True if the user credentials are valid; otherwise, false.
        /// </returns>
        public bool VerifyLogin(string userName, string password)
        {
            using (SqlConnection connection = new SqlConnection(Settings.Default.PhumlaKamnandiDatabaseConnectionString))
            {
                string query = "SELECT password FROM RECEPTIONISTS WHERE email = @userName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userName", userName);

                try
                {
                    connection.Open();
                    string storedHashedPassword = (string)command.ExecuteScalar(); // Get the hashed password.
                    if (storedHashedPassword != null)
                    {
                        // Hash the input password and compare.
                        string hashedInputPassword = HashPassword(password);
                        return storedHashedPassword.Equals(hashedInputPassword, StringComparison.OrdinalIgnoreCase);
                    }
                    return false; // User not found.
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Hashes the specified password using the SHA256 algorithm.
        /// </summary>
        /// <param name="password">The password to be hashed.</param>
        /// <returns>
        /// A string representing the hashed password in hexadecimal format.
        /// </returns>
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the password string into a byte array.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string (x2).
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion
    }
}