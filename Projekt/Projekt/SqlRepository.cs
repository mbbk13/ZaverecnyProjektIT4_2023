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

        public SqlRepository()
        {
            Connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='899BAC5729D42BA087F0616BC1630C93_ICKÁ A ZDRAVOTNICKÁ A STŘEDNÍ ŠKOLA BOSKOVICE, PŘÍSPĚVKOVÁ ORGANIZACE\PRG\PROJEKT\PROJEKTDB.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

        public List<User> GetUsers(string userName)
        {
            List<User> users = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(reader["UserName"].ToString(), Convert.ToInt32(reader["IdEmployee"])));
                        }
                    }
                }
                conn.Close();
            }
            return users;
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
