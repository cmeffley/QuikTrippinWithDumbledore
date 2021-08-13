using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreRepository
    {
        static List<StoreBase> _stores = new List<StoreBase>()
        {
            new StoreBase(789),
            new StoreBase(513),
            new StoreBase(222),
            new StoreBase(654)
        };

        public List<StoreBase> GetAllStores()
        {
            return _stores;
        }
        public static StoreBase GetSingleStoreNumber(int specificStore)
        {
            return _stores.First(store => store.StoreNumber == specificStore);
        }

        public void AddStore(StoreBase storeNumber)
        {
            _stores.Add(storeNumber);
        }

        public void RemoveStore(StoreBase storeNumber)
        {
            _stores.Remove(storeNumber);
        }
    }

}
