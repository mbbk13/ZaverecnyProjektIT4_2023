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
        public int Role { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int IdEmployee { get; set; }
        public int Id { get; set; }

        public User(string userName, int id, byte[] password, byte[] passwordSalt)
        {
            UserName = userName;
            Password = password;
            PasswordSalt = passwordSalt;
            Id=id;
        }

        public User(int id,string userName, int idEmployee,int role)
        {
            IdEmployee = idEmployee;
            UserName = userName;
            Id= id;
            Role = role;
        }

        public User(int id)
        {
            Id = id;
        }

        public User(string userName)
        {
            UserName = userName;
        }

        private void HashPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public void ResetPassword()
        {
            HashPassword("Heslo");
        }

        public bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(Password);
        }

        public void ChangePassword(string password)
        {
            HashPassword(password);
        }
    }
}
