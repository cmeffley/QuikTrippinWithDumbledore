
using QuikTrippinWithDumbledore.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreSales : StoreBase
    {

        //STORE SALES
        public static void AddToYearlyGasSales(int storeNum, decimal newSale)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNum);
            if(storeNum != store.StoreNumber)
            {
                Console.WriteLine("This store does not exist, please try again");
            }
            var storeYearlyGasSales = store.YearlyGasSales;
            var newTotal = Decimal.Add(storeYearlyGasSales, newSale);
            Console.WriteLine($"Store #{storeNum}'s new Yearly gas sales are ${newTotal}");  
        }
        public static void AddToQuarterlyGasSales(int storeNumber, decimal newSale)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNumber);
            var storeQuarterlyGasSales = store.CurrentQuarterGasSales;
            var newTotal = Decimal.Add(storeQuarterlyGasSales, newSale);
            Console.WriteLine($"Store #{storeNumber}'s new current quarter gas sales are ${newTotal}");
        }

        //ASSOCIATE
        public static void UpdateAssociateQuarterSales(int associateID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var associate = repo.GetAssociate(associateID);
            var associateQuarterSales = associate.CurrQtrRetailSales;
            var newTotal = Decimal.Add(associateQuarterSales, moreSales);
            Console.WriteLine($"{associate.FirstName} {associate.LastName}'s new Quarter sales total is {newTotal}");
        }   
        public static void UpdateAssociateYearlySales(int associateID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var associate = repo.GetAssociate(associateID);
            var associateYearlySales = associate.AnnualRetailSales;
            var newTotal = Decimal.Add(associateYearlySales, moreSales);
            Console.WriteLine($"{associate.FirstName} {associate.LastName}'s new Yearly sales total is {newTotal}");
        }   

        //DISTRICT MANAGER
        public static void UpdateDistrictManagerQuartSales(int distManagerID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var distManager = repo.GetDistrictManager(distManagerID);
            var distManagerQuartSales = distManager.CurrQtrRetailSales;
            var newTotal = Decimal.Add(distManagerQuartSales, moreSales);
            Console.WriteLine($"{distManager.FirstName} {distManager.LastName}'s new Quarter sales total is {newTotal}");
        } 
        public static void UpdateDistrictManagerYearlySales(int distManagerID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var distManager = repo.GetDistrictManager(distManagerID);
            var distManagerYearSales = distManager.AnnualRetailSales;
            var newTotal = Decimal.Add(distManagerYearSales, moreSales);
            Console.WriteLine($"{distManager.FirstName} {distManager.LastName}'s new Yearly sales total is {newTotal}");
        }

        //STORE MANAGER
        public static void UpdateStoreManagerQuartSales(int storeManagerID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var storeManager = repo.GetStoreManager(storeManagerID);
            var storeManagerQuartSales = storeManager.CurrQtrRetailSales;
            var newTotal = Decimal.Add(storeManagerQuartSales, moreSales);
            Console.WriteLine($"{storeManager.FirstName} {storeManager.LastName}'s new Quarter sales total is {newTotal}");
        }    
        public static void UpdateStoreManagerYearlySales(int storeManagerID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var storeManager = repo.GetStoreManager(storeManagerID);
            var storeManagerYearSales = storeManager.AnnualRetailSales;
            var newTotal = Decimal.Add(storeManagerYearSales, moreSales);
            Console.WriteLine($"{storeManager.FirstName} {storeManager.LastName}'s new Yearly sales total is {newTotal}");
        }

        //ASSISTANT MANAGER
        public static void UpdateAssisManagerQuartSales(int assisManagerID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var assisManager = repo.GetAssistant(assisManagerID);
            var assisManagerQuartSales = assisManager.CurrQtrRetailSales;
            var newTotal = Decimal.Add(assisManagerQuartSales, moreSales);
            Console.WriteLine($"{assisManager.FirstName} {assisManager.LastName}'s new Quarter sales total is {newTotal}");
        }     
        public static void UpdateAssisManagerYearlySales(int assisManagerID, decimal moreSales)
        {
            var repo = new EmployeeRepository();
            var assisManager = repo.GetAssistant(assisManagerID);
            var assisManagerearlySales = assisManager.AnnualRetailSales;
            var newTotal = Decimal.Add(assisManagerearlySales, moreSales);
            Console.WriteLine($"{assisManager.FirstName} {assisManager.LastName}'s new Yearly sales total is {newTotal}");
        }
     
    }
}
