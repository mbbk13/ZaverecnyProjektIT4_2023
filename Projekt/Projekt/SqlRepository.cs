using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    internal class SqlRepository
    {
        public string Connection { get; set; }
        byte[] passwordSalt;
        byte[] passwordHash;


        public SqlRepository(string connection)
        {
            this.Connection = connection;
        }

        public void Login(string userName, string password)
        {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from Users where UserName=@userName";
                        cmd.Parameters.AddWithValue("userName", userName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                            }
                        }
                    }
                    conn.Close();
                }
        }

        public void Register(string userName, string password)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Users values(@idEmployee,@userName,Convert(VARBINARY(max),@password),Convert(VARBINARY(max),@passwordSalt))";
                    cmd.Parameters.AddWithValue("userName", userName);
                    cmd.Parameters.AddWithValue("idEmployee", 1);
                    HashPassword(password);
                    cmd.Parameters.AddWithValue("password", passwordHash);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void HashPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(passwordHash);
        }
    }
}
