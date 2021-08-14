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
        public StoreManager StoreManager { get; set; }
        public AssistantManager AssistantManager { get; set; }
        public List<Associate> AssociateStoreList { get; set; }
        //do we need to add district? I added it Friday at 4:15

        public StoreBase
            (
                int storeNumber,
                decimal yearlyGasSales,
                decimal currentQuarterGasSales,
                DistrictBase district,
                StoreManager storeManager,
                AssistantManager assistantManager,
                List<Associate> associates
            )
        {
            StoreNumber = storeNumber;
            YearlyGasSales = yearlyGasSales;
            CurrentQuarterGasSales = currentQuarterGasSales;
            District = district;
            StoreManager = storeManager;
            AssistantManager = assistantManager;
            AssociateStoreList = associates;
        }

        public StoreBase()
        {
            
        }


    }
}
