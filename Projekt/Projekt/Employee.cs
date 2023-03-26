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

        public DateTime BirthDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
