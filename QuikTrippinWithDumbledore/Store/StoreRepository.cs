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
            //new StoreBase{StoreNumber = 001, StoreManager, AssistantManager, AssociateStoreList}, 
            new StoreBase
            {
                StoreNumber = 001,
                GasSales = 1140419.34m
            },
            new StoreBase{StoreNumber = 002, GasSales = 3342322.44m},
            new StoreBase{StoreNumber = 003, GasSales = 140419.34m},
            new StoreBase{StoreNumber = 004, GasSales = 2330419.34m}
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
    }
}
