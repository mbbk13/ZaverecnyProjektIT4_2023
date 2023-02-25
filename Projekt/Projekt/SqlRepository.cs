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

        public void Login(string userName, string password)
        { 
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from Users where UserName=@userName and Password=@password";
                        cmd.Parameters.AddWithValue("userName", userName);
                        cmd.Parameters.AddWithValue("password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //MessageBox.Show("Jste přihlášen jako "+ Convert.ToString(reader["UserName"]));

                            }
                        }
                }
                    conn.Close();
                }
        }
    }
}
