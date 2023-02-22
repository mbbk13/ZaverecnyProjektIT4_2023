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
        string connection;

        public SqlRepository(string connection)
        {
            this.connection = connection;
        }

        public void Login(string userName, string password)
        { 
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from Users where UserName=@userName";
                        cmd.Parameters.AddWithValue("userName", userName);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show(reader["UserName"].ToString());
                            }
                        }
                }
                    conn.Close();
                }
        }
    }
}
