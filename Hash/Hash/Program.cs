using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] PasswordHash;
            string password = "heslo123";
            var hmac = new HMACSHA512();
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            Console.WriteLine(Convert.ToBase64String(PasswordHash));
            Console.ReadKey();
        }
    }
}
