using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Employee
    {
        public Employee(int id,string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id= id;
        }

        public Employee(DateTime birthDate, string firstName, string lastName, int id, string email, string phone)
        {
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Email = email;
            Phone = phone;
        }

        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
