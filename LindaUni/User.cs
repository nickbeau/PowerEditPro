using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LindaUni
{
   public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string UserType { get; set; }
        
        /// <summary>
        /// Creates a new user object
        /// </summary>
        public User()
        {

        }

        public User(string userName, string  password, string firstName, string lastName, DateTime dateofBirth, string userType)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
            UserType = userType;

            // Hashing Password
            Password = hashpassword(password);

        }

        private string hashpassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        public bool checklogin(string password)
        {
            bool retval = false;
            byte[] hashBytes = Convert.FromBase64String(Password);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            bool success = true;
            for (int i=0;i<20;i++)
            {
                if(hashBytes[i+16] != hash[i])
                {
                    success = false;
                }

            }
            retval = success;
            return retval;
        }
    }
}
