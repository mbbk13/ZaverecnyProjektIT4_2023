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
            Connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Martin\OneDrive - Vyšší odborná škola ekonomická a zdravotnická a Střední škola Boskovice, příspěvková organizace\PRG\Projekt_2.0\projektDB.mdf';Integrated Security=True;Connect Timeout=30";
        }

        public void AddUser(string userName,int idEmployee, int role, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Users values (@idEmployee,@userName,@password,@passwordSalt,@role)";
                    cmd.Parameters.AddWithValue("userName", userName);
                    cmd.Parameters.AddWithValue("idEmployee", idEmployee);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("role", role);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void AddContract(string costumerName,string description)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Contracts values (@costumerName,@description)";
                    cmd.Parameters.AddWithValue("costumerName", costumerName);
                    cmd.Parameters.AddWithValue("description", description);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void AddWorkType(string name, string description)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into WorkTypes values (@name,@description)";
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("description", description);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void AddEmployee(string firstName, string lastName, DateTime birthDate, string email, string phone)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Employees values (@firstName,@lastName,@birthDate,@email, @phone)";
                    cmd.Parameters.AddWithValue("firstName", firstName);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("birthDate", birthDate);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void AddRole(string name)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "insert into Roles values (@Name)";
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteUser(int idUser)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Users where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteWorkType(int idWork)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from WorkTypes where IdWorkType=@idWorkType";
                    cmd.Parameters.AddWithValue("idWorkType", idWork);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteContract(int idContract)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Contracts where IdContract=@idContract";
                    cmd.Parameters.AddWithValue("idContract", idContract);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteEmployee(int idEmployee)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Employees where IdEmployee=@idEmployee";
                    cmd.Parameters.AddWithValue("IdEmployee", idEmployee);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void DeleteRole(int idRole)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from Roles where IdRole=@idRole";
                    cmd.Parameters.AddWithValue("idRole", idRole);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
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
                                user = new User(reader["UserName"].ToString(),Convert.ToInt32(reader["IdUser"]), (byte[])reader["Password"], (byte[])reader["PasswordSalt"], Convert.ToInt32(reader["Role"]));
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

        public User GetUser(int id)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdUser=@id";
                    cmd.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Convert.ToInt32(reader["IdUser"]), Convert.ToString(reader["UserName"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"]));
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

        public bool IsUsered(int id)
        {
            User user = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Users where IdEmployee=@idEmployee";
                    cmd.Parameters.AddWithValue("idEmployee", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Convert.ToInt32(reader["IdUser"]));
                        }
                    }
                }
                conn.Close();
            }
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
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
                            users.Add(new User(Convert.ToInt32(reader["IdUser"]),reader["UserName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"])));
                        }
                    }
                }
                conn.Close();
            }
            return users;
        }

        public List<Hour> GetHours()
        {
            List<Hour> hours = new List<Hour>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Hours";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hours.Add(new Hour(Convert.ToInt32(reader["IdHour"]), Convert.ToInt32(reader["AmountOfHours"]), Convert.ToDateTime(reader["Date"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["IdContract"]),Convert.ToInt32(reader["IdWorkType"])));
                        }
                    }
                }
                conn.Close();
            }
            return hours;
        }

        public List<Hour> GetHours(int idUser)
        {
            List<Hour> hours = new List<Hour>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Hours].IdHour,[Hours].IdEmployee,[Hours].[AmountOfHours],[Hours].[Date],[Hours].IdContract,[Hours].IdWorkType FROM [Hours] JOIN Employees ON [Hours].IdEmployee = Employees.IdEmployee JOIN Users ON Employees.IdEmployee = Users.IdEmployee WHERE Users.IdUser = @idUser;";
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hours.Add(new Hour(Convert.ToInt32(reader["IdHour"]), Convert.ToInt32(reader["AmountOfHours"]),  Convert.ToDateTime(reader["Date"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["IdContract"]), Convert.ToInt32(reader["IdWorkType"])));
                        }
                    }
                }
                conn.Close();
            }
            return hours;
        }

        public Hour GetHour(int idHour)
        {
            Hour hour = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * from Hours where IdHour=@idHour";
                    cmd.Parameters.AddWithValue("idHour", idHour);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hour=new Hour(Convert.ToInt32(reader["IdHour"]), Convert.ToInt32(reader["AmountOfHours"]), Convert.ToDateTime(reader["Date"]), Convert.ToInt32(reader["IdEmployee"]),Convert.ToInt32(reader["IdContract"]), Convert.ToInt32(reader["IdWorkType"]));
                        }
                    }
                }
                conn.Close();
            }
            return hour;
        }

        public List<Contract> GetContracts()
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Contracts";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contracts.Add(new Contract(Convert.ToInt32(reader["IdContract"]), reader["CostumerName"].ToString(), reader["Description"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return contracts;
        }

        public List<WorkType> GetWorkTypes()
        {
            List<WorkType> workTypes = new List<WorkType>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from WorkTypes";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            workTypes.Add(new WorkType(Convert.ToInt32(reader["IdWorkType"]), reader["Name"].ToString(), reader["Description"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return workTypes;
        }

        public Contract GetContract(int idContract)
        {
            Contract contract = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Contracts where IdContract=@idContract";
                    cmd.Parameters.AddWithValue("idContract", idContract);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contract=new Contract(Convert.ToInt32(reader["IdContract"]), reader["CostumerName"].ToString(), reader["Description"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return contract;
        }

        public WorkType GetWorkType(int idWorkType)
        {
            WorkType workType = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from WorkTypes where IdWorkType=@idWorkType";
                    cmd.Parameters.AddWithValue("idWorkType", idWorkType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            workType = new WorkType(Convert.ToInt32(reader["IdWorkType"]), reader["Name"].ToString(), reader["Description"].ToString());
                        }
                    }
                }
                conn.Close();
            }
            return workType;
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Roles";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Role(reader["Name"].ToString(), Convert.ToInt32(reader["IdRole"])));
                        }
                    }
                }
                conn.Close();
            }
            return roles;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Employees";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(Convert.ToDateTime(reader["BirthDate"]),reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), reader["Email"].ToString(), reader["Phone"].ToString()));
                        }
                    }
                }
                conn.Close();
            }
            return employees;
        }

        public Employee GetEmployee(int idEmployee)
        {
            Employee employee = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Employees where IdEmployee=@id";
                    cmd.Parameters.AddWithValue("id", idEmployee);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee((DateTime)reader["BirthDate"],reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), reader["Email"].ToString(), reader["Phone"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Zaměstnanec s takovýmto identifikačním číslem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return employee;
        }

        public Role GetRole(int idRole)
        {
            Role role=null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Roles where IdRole=@id";
                    cmd.Parameters.AddWithValue("id", idRole);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(reader["Name"].ToString(),0);
                        }
                        else
                        {
                            MessageBox.Show("Role s takovýmto identifikačním číslem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public Role GetRole(string roleName)
        {
            Role role = null;
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from Roles where Name=@roleName";
                    cmd.Parameters.AddWithValue("roleName", roleName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(null,Convert.ToInt32(reader["IdRole"]));
                        }
                        else
                        {
                            MessageBox.Show("Role s takovýmto názvem neexistuje!");
                        }
                    }
                }
                conn.Close();
            }
            return role;
        }

        public void UpdateUser(string userName,int idRole,int idUser)
        {
            using(SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set UserName=@userName,Role=@idRole where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("userName",userName);
                    cmd.Parameters.AddWithValue("idRole", idRole);
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UpdateContract(int idContract, string costumerName, string description)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Contracts set CostumerName=@costumerName, Description=@description where IdContract=@idContract";
                    cmd.Parameters.AddWithValue("costumerName", costumerName);
                    cmd.Parameters.AddWithValue("description", description);
                    cmd.Parameters.AddWithValue("idContract", idContract);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UpdateEmployee(int idEmployee,string firstName, string lastName, DateTime birthDate, string email, string phone)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Employees set FirstName=@firstName,LastName=@lastName,BirthDate=@birthDate,Email=@email,Phone=@phone where IdEmployee=@idEmployee";
                    cmd.Parameters.AddWithValue("firstName", firstName);
                    cmd.Parameters.AddWithValue("lastName", lastName);
                    cmd.Parameters.AddWithValue("birthDate", birthDate);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("phone", phone);
                    cmd.Parameters.AddWithValue("idEmployee", idEmployee);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UpdateRole(int idRole, string name)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Roles set Name=@name where IdRole=@idRole";
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("idRole", idRole);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UpdateWorkType(string name,string descrtiption, int idWorkType)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update WorkTypes set Name=@name, Description=@description where IdWorkType=@idWorkType";
                    cmd.Parameters.AddWithValue("name", name);
                    cmd.Parameters.AddWithValue("description", descrtiption);
                    cmd.Parameters.AddWithValue("idWorkType", idWorkType);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void UpdateWorkHour(int idHour,int amount,DateTime date, int idEmployee, int idContract, int idWorkType)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Hours set AmountOfHours=@amountOfHours,Date=@date,IdEmployee=@idEmployee,IdContract=@idContract,IdWorkType=@idWorkType where IdHour=@idHour";
                    cmd.Parameters.AddWithValue("amountOfHours", amount);
                    cmd.Parameters.AddWithValue("date", date);
                    cmd.Parameters.AddWithValue("idWorkType", idWorkType);
                    cmd.Parameters.AddWithValue("idEmployee", idEmployee);
                    cmd.Parameters.AddWithValue("idContract", idContract);
                    cmd.Parameters.AddWithValue("idHour", idHour);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ResetUserPassword(int idUser, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set Password=@password,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public void ChangeUserPassword(int idUser, byte[] password, byte[] passwordSalt)
        {
            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update Users set Password=@password,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    cmd.Parameters.AddWithValue("idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
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
