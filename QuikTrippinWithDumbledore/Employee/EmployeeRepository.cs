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
            new DistrictManager{FirstName="Chris", LastName="Meffley", EmployeeID=383938, CurrQtrRetailSales=2344.45m, AnnualRetailSales=135000.46m},
            new DistrictManager{FirstName="Matthew", LastName="Gonzales", EmployeeID=458945, CurrQtrRetailSales=3434.45m, AnnualRetailSales=13000.76m},
            new DistrictManager{FirstName="Jim", LastName="Conner", EmployeeID=238723, CurrQtrRetailSales=4334.45m, AnnualRetailSales=14000.99m},
            new DistrictManager{FirstName="Ellie", LastName="Walker", EmployeeID=129812, CurrQtrRetailSales=4234.45m, AnnualRetailSales=135000.55m},
        };

        static List<StoreManager> _storeManagers = new List<StoreManager>()
        {
            new StoreManager{FirstName="Ben", LastName="Jarrett", EmployeeID=111111, CurrQtrRetailSales=2234.45m, AnnualRetailSales=74686.33m},
            new StoreManager{FirstName="Casey", LastName="Walker", EmployeeID=222222, CurrQtrRetailSales=2934.45m, AnnualRetailSales=75894.55m},
            new StoreManager{FirstName="Chie", LastName="Stroud", EmployeeID=333333, CurrQtrRetailSales=2424.45m, AnnualRetailSales=85874.54m},
            new StoreManager{FirstName="Dani", LastName="Crosby", EmployeeID=444444, CurrQtrRetailSales=2264.45m, AnnualRetailSales=83746.34m},
        };

        static List<AssistantManager> _assistantManagers = new List<AssistantManager>()
        {
            new AssistantManager{FirstName="Martin", LastName="Sisk", EmployeeID=11111, CurrQtrRetailSales=1234.45m, AnnualRetailSales=4746.54m},
            new AssistantManager{FirstName="Gabby", LastName="Tobermann", EmployeeID=22222, CurrQtrRetailSales=1334.45m, AnnualRetailSales=7575.45m},
            new AssistantManager{FirstName="John", LastName="Maple", EmployeeID=33333, CurrQtrRetailSales=1854.45m, AnnualRetailSales=8585.47m},
            new AssistantManager{FirstName="Holly", LastName="Parsons", EmployeeID=44444, CurrQtrRetailSales=1454.45m, AnnualRetailSales=9898.45m},
        };
        
        static List<Associate> _associates = new List<Associate>()
        {
            new Associate{FirstName="Hunter", LastName="Juneau", EmployeeID=1, CurrQtrRetailSales=234.45m, AnnualRetailSales=1746.54m},
            new Associate{FirstName="Jesse", LastName="Robinson", EmployeeID=2, CurrQtrRetailSales=994.38m, AnnualRetailSales=2746.54m},
            new Associate{FirstName="Juan", LastName="Davila", EmployeeID=3, CurrQtrRetailSales=848.57m, AnnualRetailSales=2346.54m},
            new Associate{FirstName="Katy", LastName="Fry", EmployeeID=4, CurrQtrRetailSales=748.57m, AnnualRetailSales=1546.54m},
            new Associate{FirstName="Lindsey", LastName="Satterfield", EmployeeID=5, CurrQtrRetailSales=234.54m, AnnualRetailSales=2946.54m},
            new Associate{FirstName="Mitchell", LastName="Crumbley", EmployeeID=6, CurrQtrRetailSales=737.37m, AnnualRetailSales=2246.54m},
            new Associate{FirstName="Nathan", LastName="Keith", EmployeeID=7, CurrQtrRetailSales=983.47m, AnnualRetailSales=3246.54m},
            new Associate{FirstName="Rob", LastName="Cole", EmployeeID=8, CurrQtrRetailSales=847.35m, AnnualRetailSales=2246.54m},
            new Associate{FirstName="Sean", LastName="Rossettie", EmployeeID=9, CurrQtrRetailSales=647.35m, AnnualRetailSales=2146.54m},
            new Associate{FirstName="Sara", LastName="Schoonover", EmployeeID=10, CurrQtrRetailSales=456.45m, AnnualRetailSales=1946.54m},
            new Associate{FirstName="Honey-Rae", LastName="Swan", EmployeeID=11, CurrQtrRetailSales=234.55m, AnnualRetailSales=2246.54m},
            new Associate{FirstName="Tad", LastName="Sekeres", EmployeeID=12, CurrQtrRetailSales=200.34m, AnnualRetailSales=1346.54m},
        };

        public void AddAssociate(Associate associate)
        {
            _associates.Add(associate);
        }

        public Associate GetAssociate(int associateId)
        {
            return _associates.First(employee => employee.EmployeeID == associateId);
        }
        public List<Associate> GetAllAssociates()
        {
            return _associates;
        }
        public static bool DoesAssociateIdExist(int assocId)
        {
            var repo = new EmployeeRepository();
            var associates = repo.GetAllAssociates();
            return associates.Any(associate => associate.EmployeeID == assocId);
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
        public List<AssistantManager> GetAllAssisManagers()
        {
            return _assistantManagers;
        }
        public static bool DoesAssisManagerIdExist(int assisId)
        {
            var repo = new EmployeeRepository();
            var assisManager = repo.GetAllAssisManagers();
            return assisManager.Any(assistant => assistant.EmployeeID == assisId);
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
        public List<StoreManager> GetAllStoreManagers()
        {
            return _storeManagers;
        }
        public static bool DoesStoreManagerIdExist(int storeManagerId)
        {
            var repo = new EmployeeRepository();
            var storeManager = repo.GetAllStoreManagers();
            return storeManager.Any(manager => manager.EmployeeID == storeManagerId);
        }

        public void RemoveStoreManager(StoreManager storeManager)
        {
            _storeManagers.Remove(storeManager);
        }

        public DistrictManager GetDistrictManager(int distManagerID)
        {
            return _districtManagers.First(employee => employee.EmployeeID == distManagerID);
        }
        public List<DistrictManager> GetAllDistManagers()
        {
            return _districtManagers;
        }
        public static bool DoesDistricManIdExist(int DistManId)
        {
            var repo = new EmployeeRepository();
            var distManagers = repo.GetAllDistManagers();
            return distManagers.Any(associate => associate.EmployeeID == DistManId);
        }

        public List<DistrictManager> GetAllDistrictManagers()
        {
            return _districtManagers;
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
        public decimal CurrQtrRetailSales { get; set; } //don't forget to put a "m" after the number
        public decimal AnnualRetailSales { get; set; }
    }
}
