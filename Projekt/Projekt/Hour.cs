using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Hour
    {
        public Hour(int id, int hours, int idEmployee, int idContract, int idWorkType, DateTime date)
        {
            Id = id;
            Hours = hours;
            IdEmployee = idEmployee;
            IdContract = idContract;
            IdWorkType = idWorkType;
            Date = date;
        }

        public int Id { get; set; }
        public int Hours { get; set; }
        public int IdEmployee { get; set; }
        public int IdContract { get; set; }
        public int IdWorkType { get; set; }
        public DateTime Date { get; set; }
    }
}
