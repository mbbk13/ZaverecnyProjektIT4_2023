using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class User
    {
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int IdEmployee { get; set; }

        public User(string userName, byte[] password, byte[] passwordSalt)
        {
            UserName = userName;
            Password = password;
            PasswordSalt = passwordSalt;
        }

        public User(string userName, int idEmployee)
        {
            IdEmployee = idEmployee;
            UserName = userName;
        }



        /*public void HashPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }*/

        public bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(Password);
        }
    }
}
