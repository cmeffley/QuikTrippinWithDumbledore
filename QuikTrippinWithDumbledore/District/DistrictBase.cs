using QuikTrippinWithDumbledore.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.District
{
    class DistrictBase
    {
        public string DistrictName { get; set; }
        public List<StoreBase> StoreList { get; set; }
        //public DistrictManager DistrictManager { get; set; }
    }
}
