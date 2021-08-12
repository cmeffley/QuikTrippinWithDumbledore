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
            new DistrictManager{FirstName="Chris", LastName="Meffley", EmployeeID=383938, RetailSales=135000.46m},
            new DistrictManager{FirstName="Matthew", LastName="Gonzales", EmployeeID=458945, RetailSales=13000.76m},
            new DistrictManager{FirstName="Jim", LastName="Conner", EmployeeID=238723, RetailSales=14000.99m},
            new DistrictManager{FirstName="Ellie", LastName="Walker", EmployeeID=129812, RetailSales=135000.55m},
        };

        static List<StoreManager> _storeManagers = new List<StoreManager>()
        {
            new StoreManager{FirstName="Ben", LastName="Jarrett", EmployeeID=111111, RetailSales=74686.33m},
            new StoreManager{FirstName="Casey", LastName="Walker", EmployeeID=222222, RetailSales=75894.55m},
            new StoreManager{FirstName="Chie", LastName="Stroud", EmployeeID=333333, RetailSales=85874.54m},
            new StoreManager{FirstName="Dani", LastName="Crosby", EmployeeID=444444, RetailSales=83746.34m},
        };

        static List<AssistantManager> _assistantManagers = new List<AssistantManager>()
        {
            new AssistantManager{FirstName="Martin", LastName="Sisk", EmployeeID=11111, RetailSales=4746.54m},
            new AssistantManager{FirstName="Gabby", LastName="Tobermann", EmployeeID=22222, RetailSales=7575.45m},
            new AssistantManager{FirstName="John", LastName="Maple", EmployeeID=33333, RetailSales=8585.47m},
            new AssistantManager{FirstName="Holly", LastName="Parsons", EmployeeID=44444, RetailSales=9898.45m},
        };
        
        static List<Associate> _associates = new List<Associate>()
        {
            new Associate{FirstName="Hunter", LastName="Juneau", EmployeeID=1, RetailSales=234.45m},
            new Associate{FirstName="Jesse", LastName="Robinson", EmployeeID=2, RetailSales=994.38m},
            new Associate{FirstName="Juan", LastName="Davila", EmployeeID=3, RetailSales=848.57m},
            new Associate{FirstName="Katy", LastName="Fry", EmployeeID=4, RetailSales=748.57m},
            new Associate{FirstName="Lindsey", LastName="Satterfield", EmployeeID=5, RetailSales=234.54m},
            new Associate{FirstName="Mitchell", LastName="Crumbley", EmployeeID=6, RetailSales=737.37m},
            new Associate{FirstName="Nathan", LastName="Keith", EmployeeID=7, RetailSales=983.47m},
            new Associate{FirstName="Rob", LastName="Cole", EmployeeID=8, RetailSales=847.35m},
            new Associate{FirstName="Sean", LastName="Rossettie", EmployeeID=9, RetailSales=647.35m},
            new Associate{FirstName="Sara", LastName="Schoonover", EmployeeID=10, RetailSales=456.45m},
            new Associate{FirstName="Honey-Rae", LastName="Swan", EmployeeID=11, RetailSales=234.55m},
            new Associate{FirstName="Tad", LastName="Sekeres", EmployeeID=12, RetailSales=200.34m},
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

        public AssistantManager GetAssistant(int assistantId)
        {
            return _assistantManagers.First(employee => employee.EmployeeID == assistantId);
        }
        public void RemoveAssistantManager(AssistantManager assistant)
        {
            _assistantManagers.Remove(assistant);
        }

        public void AddStoreManager(StoreManager storeManager)
        {
            _storeManagers.Add(storeManager);
        }

        public StoreManager GetStoreManager(int storeManagerId)
        {
            return _storeManagers.First(employee => employee.EmployeeID == storeManagerId);
        }
        public void RemoveStoreManager(StoreManager storeManager)
        {
            _storeManagers.Remove(storeManager);
        }

        //public void AddDistrictManager(DistrictManager districtManager)
        //{
        //    _districtManagers.Add(districtManager);
        //}

        //public void RemoveDistrictManager(DistrictManager districtManager)
        //{
        //    _districtManagers.Remove(districtManager);
        //}

    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }
        public decimal RetailSales { get; set; } //don't forget to put a "m" after the number
    }
}
