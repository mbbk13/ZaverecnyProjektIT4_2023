using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Hour
    {
        public Hour(int id, int amount, DateTime date,int idEmployee,int idContract,int idWorkType)
        {
            Id = id;
            Amount = amount;
            Date = date;
            IdEmployee = idEmployee;
            IdContract = idContract;
            IdWorkType = idWorkType;
        }

        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public int IdContract { get; set; }
        public int IdWorkType { get; set; }
        public int IdEmployee { get; set; }

    }
}
