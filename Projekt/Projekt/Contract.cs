using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Contract
    {
        public Contract(int id, string costumerName, string description)
        {
            Id = id;
            CostumerName = costumerName;
            Description = description;
        }

        public int Id { get; set; }
        public string CostumerName { get; set; }
        public string Description { get; set; }
    }
}
