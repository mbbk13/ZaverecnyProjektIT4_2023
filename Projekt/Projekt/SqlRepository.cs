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

        public SqlRepository(string connection)
        {
            this.Connection = connection;
        }

        public User GetUser(string userName)
        {
            User user=null;
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
                                user = new User(reader["UserName"].ToString(), (byte[])reader["Password"], (byte[])reader["PasswordSalt"]);
                            }
                            else
                            {
                                MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
                            }
                        }
                    }
                    conn.Close();
                }
            return user;
        }

        /*public void Register(string userName, string password)
        {
            User = new User();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Users values(@idEmployee,@userName,Convert(VARBINARY(max),@password),Convert(VARBINARY(max),@passwordSalt))";
                    cmd.Parameters.AddWithValue("userName", userName);
                    cmd.Parameters.AddWithValue("idEmployee", 1);
                    User.HashPassword(password);
                    cmd.Parameters.AddWithValue("password", User.Password);
                    cmd.Parameters.AddWithValue("passwordSalt", User.PasswordSalt);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }*/
    }
}
