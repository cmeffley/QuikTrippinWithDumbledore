using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuikTrippinWithDumbledore.District;
using QuikTrippinWithDumbledore.Employee;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreBase
    {
        public int StoreNumber { get; set; }
        public decimal YearlyGasSales { get; set; }
        public decimal CurrentQuarterGasSales { get; set; }
        public DistrictBase District { get; set; }
        public List<StoreManager> StoreManagerList { get; set; }
        public List<AssistantManager> AssistantManagerList { get; set; }
        public List<Associate> AssociateList { get; set; }
        //do we need to add district? I added it Friday at 4:15

        public StoreBase
            (
                int storeNumber,
                decimal yearlyGasSales,
                decimal currentQuarterGasSales,
                DistrictBase district,
                List<StoreManager> storeManager,
                List<AssistantManager> assistantManager,
                List<Associate> associates
            )
        {
            StoreNumber = storeNumber;
            YearlyGasSales = yearlyGasSales;
            CurrentQuarterGasSales = currentQuarterGasSales;
            District = district;
            StoreManagerList = storeManager;
            AssistantManagerList = assistantManager;
            AssociateList = associates;
        }

        public StoreBase()
        {
            
        }


    }
}
