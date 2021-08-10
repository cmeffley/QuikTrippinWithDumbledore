using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Employee
{
    class EmployeeBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public decimal RetailSales { get; set; } //don't forget to put a "m" after the number

    }
}
