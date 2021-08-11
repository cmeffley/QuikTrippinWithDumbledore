using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreRepository
    {
        static List<StoreBase> _stores = new List<StoreBase>();

        public List<StoreBase> GetStores()
        {
            return _stores;
            throw new NotImplementedException();
        }

        public void Add(StoreBase store)
        {
            _stores.Add(store);
        }

    }
}
