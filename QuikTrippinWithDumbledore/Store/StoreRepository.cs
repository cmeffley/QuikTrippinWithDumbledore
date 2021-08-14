using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuikTrippinWithDumbledore.District;
using QuikTrippinWithDumbledore.Employee;

namespace QuikTrippinWithDumbledore.Store
{
    class StoreRepository
    {
        //EmployeeRepository repo = new EmployeeRepository();
        //StoreManager = repo.GetStoreManager(), //trying something
        //how do we use the repo to pull in pre-populated date from EmployeeRespository

        static List<StoreBase> _stores = new List<StoreBase>()

        {
            new StoreBase()
            {
                StoreNumber = 001,
                YearlyGasSales = 3342341.44m,
                CurrentQuarterGasSales = 122135.24m,
                StoreManagerList = new List<StoreManager>()
                {
                    new StoreManager{FirstName="Ben", LastName="Jarrett", EmployeeID=111111, CurrQtrRetailSales=2234.45m, AnnualRetailSales=74686.33m }
                },

                AssistantManagerList = new List<AssistantManager>()
                {
                    new AssistantManager{FirstName="Martin", LastName="Sisk", EmployeeID=11111, CurrQtrRetailSales=1234.45m, AnnualRetailSales=4746.54m }
                },
                AssociateList = new List<Associate>()
                {
                    new Associate{FirstName="Hunter", LastName="Juneau", EmployeeID=1, CurrQtrRetailSales=234.45m, AnnualRetailSales=1746.54m},
                    new Associate{FirstName="Jesse", LastName="Robinson", EmployeeID=2, CurrQtrRetailSales=994.38m, AnnualRetailSales=2746.54m},
                    new Associate{FirstName="Juan", LastName="Davila", EmployeeID=3, CurrQtrRetailSales=848.57m, AnnualRetailSales=2346.54m},
                    new Associate{FirstName="Katy", LastName="Fry", EmployeeID=4, CurrQtrRetailSales=748.57m, AnnualRetailSales=1546.54m},
                }

            },
             new StoreBase()
            {
                StoreNumber = 002,
                YearlyGasSales = 3342322.42m,
                CurrentQuarterGasSales = 12235.24m,
                StoreManagerList = new List<StoreManager>()
                {
                    new StoreManager{FirstName="Casey", LastName="Walker", EmployeeID=222222, CurrQtrRetailSales=2934.45m, AnnualRetailSales=75894.55m }
                },

                AssistantManagerList = new List<AssistantManager>()
                {
                    new AssistantManager{FirstName="Gabby", LastName="Tobermann", EmployeeID=22222, CurrQtrRetailSales=1334.45m, AnnualRetailSales=7575.45m }
                },
                AssociateList = new List<Associate>()
                {
                    new Associate{FirstName="Lindsey", LastName="Satterfield", EmployeeID=5, CurrQtrRetailSales=234.54m, AnnualRetailSales=2946.54m},
                    new Associate{FirstName="Mitchell", LastName="Crumbley", EmployeeID=6, CurrQtrRetailSales=737.37m, AnnualRetailSales=2246.54m},
                    new Associate{FirstName="Nathan", LastName="Keith", EmployeeID=7, CurrQtrRetailSales=983.47m, AnnualRetailSales=3246.54m}
                }

            },
             new StoreBase()
            {
                StoreNumber = 003,
                YearlyGasSales = 3342322.42m,
                CurrentQuarterGasSales = 12235.24m,
                StoreManagerList = new List<StoreManager>()
                {
                    new StoreManager{FirstName="Chie", LastName="Stroud", EmployeeID=333333, CurrQtrRetailSales=2424.45m, AnnualRetailSales=85874.54m }
                },

                AssistantManagerList = new List<AssistantManager>()
                {
                    new AssistantManager{FirstName="John", LastName="Maple", EmployeeID=33333, CurrQtrRetailSales=1854.45m, AnnualRetailSales=8585.47m }
                },
                AssociateList = new List<Associate>()
                {
                    new Associate{FirstName="Sara", LastName="Schoonover", EmployeeID=10, CurrQtrRetailSales=456.45m, AnnualRetailSales=1946.54m},
                    new Associate{FirstName="Honey-Rae", LastName="Swan", EmployeeID=11, CurrQtrRetailSales=234.55m, AnnualRetailSales=2246.54m},
                    new Associate{FirstName="Tad", LastName="Sekeres", EmployeeID=12, CurrQtrRetailSales=200.34m, AnnualRetailSales=1346.54m},
                }

            },
             new StoreBase()
            {
                StoreNumber = 004,
                YearlyGasSales = 2330419.34m,
                CurrentQuarterGasSales = 1266635.24m,
                StoreManagerList = new List<StoreManager>()
                {
                    new StoreManager{FirstName="Dani", LastName="Crosby", EmployeeID=444444, CurrQtrRetailSales=2264.45m, AnnualRetailSales=83746.34m }
                },

                AssistantManagerList = new List<AssistantManager>()
                {
                    new AssistantManager{FirstName="Holly", LastName="Parsons", EmployeeID=44444, CurrQtrRetailSales=1454.45m, AnnualRetailSales=9898.45m }
                },
                AssociateList = new List<Associate>()
                {
                    new Associate{FirstName="Lindsey", LastName="Satterfield", EmployeeID=5, CurrQtrRetailSales=234.54m, AnnualRetailSales=2946.54m},
                    new Associate{FirstName="Mitchell", LastName="Crumbley", EmployeeID=6, CurrQtrRetailSales=737.37m, AnnualRetailSales=2246.54m},
                    new Associate{FirstName="Nathan", LastName="Keith", EmployeeID=7, CurrQtrRetailSales=983.47m, AnnualRetailSales=3246.54m}
                }

            }, 
         
            //new StoreBase{StoreNumber = 002, YearlyGasSales = 3342322.44m, CurrentQuarterGasSales = 12235.24m},
            //new StoreBase{StoreNumber = 003, YearlyGasSales = 140419.34m, CurrentQuarterGasSales = 12435.24m},
            //new StoreBase{StoreNumber = 004, YearlyGasSales = 2330419.34m, CurrentQuarterGasSales = 12445.24m}
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

        public StoreBase GetSingleStore(int specificStore)
        {
            return _stores.First(store => store.StoreNumber == specificStore);
        }

        public void AddAssociateToStore(int storeNumber, Associate associate)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNumber);
            store.AssociateList.Add(associate);
        }
        public void AddAssistantManagerToStore(int storeNumber, AssistantManager assistantManager)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNumber);
            store.AssistantManagerList.Add(assistantManager);
        }
        public void AddStoreManagerToStore(int storeNumber, StoreManager storeManager)
        {
            var repo = new StoreRepository();
            var store = repo.GetSingleStore(storeNumber);
            store.StoreManagerList.Add(storeManager);
        }

        public bool DoesStoreIdAlreadyExist(int storeNumber)
        {
            var repo = new StoreRepository();
            var stores = repo.GetStores();

            foreach (var store in stores)
            {
                if (store.StoreNumber == storeNumber)
                {
                    return true;
                }
            }
            return false;
            
        }
    }

}
