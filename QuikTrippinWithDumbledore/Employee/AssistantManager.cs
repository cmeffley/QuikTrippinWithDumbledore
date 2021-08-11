using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Employee
{
    class AssistantManager : Employee
    {
        public bool Scheduling { get; set; } = true;
        public bool Opening { get; set; } = true;
        public bool Closing { get; set; } = true;
        public bool BalanceBooks { get; set; }
        public bool OrderInventory { get; set; }
        public bool OrderEquipmentServicing { get; set; }
    }
}
