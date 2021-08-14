
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreSales : StoreBase
    {
        //Quarterly sales:
        //Gas Current Quarter & 
        //Retail
        // use methods to create claculations for quarterly and annual sales 
        //public double YearlyGasSales { get; set; }
        //public double CurrentQuarterGasSales { get; set; }

        public static void AddToYearlyGasSales(int storeNumber, decimal newSale)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNumber);
            var storeGasSales = store.YearlyGasSales;
            var newTotal = Decimal.Add(storeGasSales, newSale);
            Console.WriteLine($"Store #{storeNumber}'s new Yearly gas sales are ${newTotal}");  
        }
        public static void AddToQuarterlyGasSales(int storeNumber, decimal newSale)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNumber);
            var storeGasSales = store.CurrentQuarterGasSales;
            var newTotal = Decimal.Add(storeGasSales, newSale);
            Console.WriteLine($"Store #{storeNumber}'s new Yearly gas sales are ${newTotal}");
        }

        //public StoreBase GetSingleStore(int specificStore)
        //{
        //    return _stores.First(store => store.StoreNumber == specificStore);
        //}

        //public void AddAssociateToStore(int storeNumber, Associate associate)
        //{
        //    var repo = new StoreRepository();
        //    var store = repo.GetSingleStore(storeNumber);
        //    store.AssociateStoreList.Add(associate);
        //}
    }
}
