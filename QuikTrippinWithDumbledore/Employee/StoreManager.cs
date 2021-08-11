using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Employee
{
    class StoreManager : Employee
    {
        public bool Scheduling { get; set; } = true;
        public bool Opening { get; set; } = true;
        public bool Closing { get; set; } = true;
        public bool BalanceBooks { get; set; } = true;
        public bool OrderInventory { get; set; } = true;
        public bool OrderEquipmentServicing { get; set; } = true;
        public void Hire(string firstName, string lastName, int employeeId)
        {
            var newHire = new Associate
            {
                FirstName = firstName,
                LastName = lastName,
                EmployeeID = employeeId,
                RetailSales = 0
            };
            var repo = new EmployeeRepository();
            repo.AddAssociate(newHire);
        }
        public void Fire(string firstName, string lastName, int employeeId)
        {
            //remove them from list
            //make a similar function for assistant manager
        }
        public void Promote(int associateID)
        {
            var repo = new EmployeeRepository();
            var associate = repo.GetAssociate(associateID);
            var newAssistantManager = new AssistantManager
            {
                FirstName = associate.FirstName,
                LastName = associate.LastName,
                EmployeeID = associate.EmployeeID,
                RetailSales = 0 //reset sales in new role
            };
            repo.AddAssistantManager(newAssistantManager);
        }

        private void GetAssociate(int associateID)
        {
            throw new NotImplementedException();
        }

        public void HireAssistantManagerFromOutside(string firstName, string lastName, int employeeId)
        {
            var newAssistantManager = new AssistantManager
            {
                FirstName = firstName,
                LastName = lastName,
                EmployeeID = employeeId,
                RetailSales = 0
            };
            var repo = new EmployeeRepository();
            repo.AddAssistantManager(newAssistantManager);
        }
    }
}
