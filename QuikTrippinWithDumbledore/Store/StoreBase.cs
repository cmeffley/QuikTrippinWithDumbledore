using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreBase
    {
        public int StoreNumber { get; set; }
        //public StoreManager StoreManager { get; set; }
        //public AssistantManager AssistantManager { get; set; }
        //public List<Associate> AssociateStoreList { get; set; }
        public double Gas { get; set; }

        public StoreBase(int storenumber)
        {
            StoreNumber = storenumber;
        }

    }
}
