using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuikTrippinWithDumbledore.Employee;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreRepository
    {
        static List<StoreBase> _stores = new List<StoreBase>
        {
            new StoreBase{StoreNumber = 001, YearlyGasSales = 3342341.44m, CurrentQuarterGasSales = 122135.24m},
            new StoreBase{StoreNumber = 002, YearlyGasSales = 3342322.44m, CurrentQuarterGasSales = 12235.24m},
            new StoreBase{StoreNumber = 003, YearlyGasSales = 140419.34m, CurrentQuarterGasSales = 12435.24m},
            new StoreBase{StoreNumber = 004, YearlyGasSales = 2330419.34m, CurrentQuarterGasSales = 12445.24m}
            //need to add employees from EmpoloyeeRepository 
        };

        public List<StoreBase> GetStores()
        {
            return _stores;
        }

        public void Add(StoreBase store)
        {
            _stores.Add(store);
        }

        public void RemoveStore(int storeNumber)
        {
            var storeToRemove = _stores.First(store => store.StoreNumber == storeNumber);
            _stores.Remove(storeToRemove);
        }

        public static StoreBase GetSingleStoreNumber(int specificStore)
        {
            return _stores.First(store => store.StoreNumber == specificStore);
        }

    }

}
