using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Library_Student.Data;
using System.Linq;

namespace Library_Student.Service
{
    public class CetUserService
    {
        private LibraryDb db;
        public CetUserService()
        {
            db = new LibraryDb();
        }
        public CetUser Login(string Username, string Password)
        {
            string hashedPassword = hashPassword(Password);
            var loginUser = db.CetUsers.FirstOrDefault(u => u.UserName == Username && u.Password == hashedPassword);

            return loginUser;
        }

        public string hashPassword(string plainPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainPassword);
                //ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(plainBytes);

                //Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i =0; i< bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool Insert(CetUser cetUser)
        {
            return true;
        }


    }
}
