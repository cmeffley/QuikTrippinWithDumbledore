using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Employee
{
    class EmployeeRepository
    {
        static List<DistrictManager> _districtManagers = new List<DistrictManager>()
        {

        };

        static List<StoreManager> _storeManagers = new List<StoreManager>()
        {

        };

        static List<AssistantManager> _assistantManagers = new List<AssistantManager>()
        {

        };
        
        static List<Associate> _associates = new List<Associate>()
        {

        };

        public void AddAssociate(Associate associate)
        {
            _associates.Add(associate);
        }

        public Associate GetAssociate(int associateId)
        {
            return _associates.First(employee => employee.EmployeeID == associateId);
        }

        public void RemoveAssociate(Associate associate)
        {
            _associates.Remove(associate);
        }

        public void AddAssistantManager(AssistantManager assistant)
        {
            _assistantManagers.Add(assistant);
        }

        public void RemoveAssistantManager(AssistantManager assistant)
        {
            _assistantManagers.Remove(assistant);
        }

        public void AddStoreManager(StoreManager storeManager)
        {
            _storeManagers.Add(storeManager);
        }

        public void RemoveStoreManager(StoreManager storeManager)
        {
            _storeManagers.Remove(storeManager);
        }

        public void AddDistrictManager(DistrictManager districtManager)
        {
            _districtManagers.Add(districtManager);
        }

        public void RemoveDistrictManager(DistrictManager districtManager)
        {
            _districtManagers.Remove(districtManager);
        }

    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public decimal RetailSales { get; set; } //don't forget to put a "m" after the number
    }
}
