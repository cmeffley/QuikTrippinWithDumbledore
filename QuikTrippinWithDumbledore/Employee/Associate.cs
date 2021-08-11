using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Employee
{
    class Associate : Employee
    {
        public int Merit { get; set; } = 0;
      
        public void EarnsMerit()
        {
            Merit += 1;
        }
        public void LosesMerit()
        {
            if (Merit > 0)
            {
                Merit -= 1;
            }
        }
    }
}
