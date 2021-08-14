using QuikTrippinWithDumbledore.Employee;
using QuikTrippinWithDumbledore.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.District
{
    class DistrictRepository
    {
        static List<DistrictBase> _districts = new List<DistrictBase>
        {
            new DistrictBase
            {
                DistrictName="North", 
                DistrictManager= new DistrictManager{FirstName="Chris", LastName="Meffley", EmployeeID=383938, CurrQtrRetailSales=2344.45m, AnnualRetailSales=135000.46m},
                StoreList = new List<StoreBase>
                {
                    new StoreBase
                    {
                        StoreNumber = 001,
                        YearlyGasSales = 3342341.44m,
                        CurrentQuarterGasSales = 122135.24m,
                        StoreManagerList = new List<StoreManager>
                        {
                            new StoreManager{FirstName="Ben", LastName="Jarrett", EmployeeID=111111, CurrQtrRetailSales=2234.45m, AnnualRetailSales=74686.33m }
                        },
                        AssistantManagerList = new List<AssistantManager>
                        {
                            new AssistantManager{FirstName="Martin", LastName="Sisk", EmployeeID=11111, CurrQtrRetailSales=1234.45m, AnnualRetailSales=4746.54m }
                        },
                        AssociateList = new List<Associate>
                        {
                            new Associate{FirstName="Hunter", LastName="Juneau", EmployeeID=1, CurrQtrRetailSales=234.45m, AnnualRetailSales=1746.54m},
                            new Associate{FirstName="Jesse", LastName="Robinson", EmployeeID=2, CurrQtrRetailSales=994.38m, AnnualRetailSales=2746.54m},
                            new Associate{FirstName="Juan", LastName="Davila", EmployeeID=3, CurrQtrRetailSales=848.57m, AnnualRetailSales=2346.54m},
                            new Associate{FirstName="Katy", LastName="Fry", EmployeeID=4, CurrQtrRetailSales=748.57m, AnnualRetailSales=1546.54m},
                        }
                    },

                },
            }, 
            new DistrictBase
            {
                DistrictName="South",
                DistrictManager= new DistrictManager{FirstName="Matthew", LastName="Gonzales", EmployeeID=458945, CurrQtrRetailSales=3434.45m, AnnualRetailSales=13000.76m},
                StoreList = new List<StoreBase>
                {
                    new StoreBase
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
                    }
                }
            },
            new DistrictBase
            {
                DistrictName="East",
                DistrictManager = new DistrictManager{FirstName="Jim", LastName="Conner", EmployeeID=238723, CurrQtrRetailSales=4334.45m, AnnualRetailSales=14000.99m},
                StoreList = new List<StoreBase>
                {
                    new StoreBase
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
                    }
                }
            },
            new DistrictBase
            {
                DistrictName="West",
                DistrictManager = new DistrictManager{FirstName="Ellie", LastName="Walker", EmployeeID=129812, CurrQtrRetailSales=4234.45m, AnnualRetailSales=135000.55m},
                StoreList = new List<StoreBase>
                {
                    new StoreBase
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

                    }
                }
            },
        };

        public List<DistrictBase> GetDistricts()
        {
            return _districts;
        }
        public DistrictBase GetDistrict(string districtName)
        {
            return _districts.First(district => district.DistrictName == districtName);
        }
        public void AddNewDistrict(DistrictBase district)
        {
            _districts.Add(district);
        }

        public void RemoveDistrict(string districtName)
        {
            var districtToRemove = _districts.First(district => district.DistrictName == districtName);
            _districts.Remove(districtToRemove);
        }
    }
}
