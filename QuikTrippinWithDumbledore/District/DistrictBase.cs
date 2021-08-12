using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuikTrippinWithDumbledore.Employee;
using QuikTrippinWithDumbledore.Store;

namespace QuikTrippinWithDumbledore.District
{
    class DistrictBase
    {
        public List<StoreBase> StoreList { get; set; }
        public DistrictManager DistrictManager { get; set; }
        public string DistrictName { get; set; }
    }
}
