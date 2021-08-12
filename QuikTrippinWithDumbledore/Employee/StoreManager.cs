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
        public void HireAssociate(string firstName, string lastName, int employeeId)
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
        public void FireAssociate(int associateId)
        {
            var repo = new EmployeeRepository();
            var associate = repo.GetAssociate(associateId);
            repo.RemoveAssociate(associate);
        }
        public void PromoteAssociate(int associateID)
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
        public void FireAssistantManager(int assistantId)
        {
            var repo = new EmployeeRepository();
            var assistantManager = repo.GetAssistant(assistantId);
            repo.RemoveAssistantManager(assistantManager);
        }
    }
}
