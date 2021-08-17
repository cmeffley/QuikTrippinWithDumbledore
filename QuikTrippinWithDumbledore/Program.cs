using QuikTrippinWithDumbledore.District;
using QuikTrippinWithDumbledore.Employee;
using QuikTrippinWithDumbledore.Store;
using System;
using System.Collections.Generic;

namespace QuikTrippinWithDumbledore
{
    class Program
    {
        static void Main(string[] args)
        {
            static void DisplayMenu()
            {
                Console.WriteLine("QuikTrip Management Systems");
                Console.WriteLine();
                Console.WriteLine("1) Enter District Sales");
                Console.WriteLine("2) Generate District Report");
                Console.WriteLine("3) Add New Employee");
                Console.WriteLine("4) Add a Store or District");
                Console.WriteLine("5) Exit");
                Console.WriteLine("Type the number of the desired option:");
            }

            static void DistrictSalesMenu()
            {
                Console.WriteLine("1) Update Gas Sales");
                Console.WriteLine("2) Update Employee Retail Sales");
                Console.WriteLine("3) Exit");
            }

            var loopControl = true;
            while (loopControl)
            {
                DisplayMenu();
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":    
                        var loop = true;
                        DistrictSalesMenu();
                        var salesInput = Console.ReadLine();
                        while (loop)
                        {
                            switch (salesInput)
                            {
                                case "1":
                                    Console.WriteLine("1) Current Quarter Sales\n2) Yearly Gas Sales");
                                    var whichSale = Console.ReadLine();
                                    if (whichSale == "1")
                                    {
                                        Console.WriteLine("Enter Store Number");
                                        int storeNumber = Convert.ToInt32(Console.ReadLine());
                                        if (StoreRepository.DoesStoreIdAlreadyExist(storeNumber) == false)
                                        {
                                            Console.WriteLine("That Store does not exist");
                                            break;
                                        }
                                        Console.WriteLine("Enter Additional Quarterly Gas Sales");
                                        decimal gasSale = Convert.ToDecimal(Console.ReadLine());
                                        StoreSales.AddToQuarterlyGasSales(storeNumber, gasSale);
                                        Console.WriteLine();
                                        Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more store sales");
                                        var enter = Console.ReadLine();
                                        if (enter.Equals(""))
                                            loop = false;
                                        else
                                            break;
                                    }
                                    else if (whichSale == "2")
                                    {
                                        Console.WriteLine("Enter Store Number");
                                        int storeNumber = Convert.ToInt32(Console.ReadLine());
                                        if (StoreRepository.DoesStoreIdAlreadyExist(storeNumber) == false)
                                        {
                                            Console.WriteLine("That Store does not exist");
                                            break;
                                        }
                                        Console.WriteLine("Enter Additional Yearly Gas Sales");
                                        decimal gasSale = Convert.ToDecimal(Console.ReadLine());
                                        StoreSales.AddToYearlyGasSales(storeNumber, gasSale);
                                        Console.WriteLine();
                                        Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more store sales");
                                        var enter = Console.ReadLine();
                                        if (enter.Equals(""))
                                            loop = false;
                                        else
                                            break;
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Number:\n1) District Manager\n2) Store Manager\n3) Assistant Manager\n4) Associate\n5) Exit");
                                    var chooseSale = Console.ReadLine();
                                    if(chooseSale == "1")
                                    {
                                        Console.WriteLine("District Manager:\n1) Current Quarter Sales\n2) Yearly Sales");
                                        var distManSale = Console.ReadLine();
                                        if (distManSale == "1")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesDistricManIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter District Manager's additional Quarterly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateDistrictManagerQuartSales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                        else if (distManSale == "2")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesDistricManIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter District Manager's additional Yearly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateDistrictManagerYearlySales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                    }
                                    else if(chooseSale == "2")
                                    {
                                        Console.WriteLine("Store Manager:\n1) Current Quarter Sales\n2) Yearly Sales");
                                        var storeManSale = Console.ReadLine();
                                        if (storeManSale == "1")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesStoreManagerIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter Store Manager's additional Quarterly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateStoreManagerQuartSales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                        else if (storeManSale == "2")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesStoreManagerIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter Store Manager's additional Yearly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateStoreManagerYearlySales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                    }
                                    else if(chooseSale == "3")
                                    {
                                        Console.WriteLine("Assistant Manager:\n1) Current Quarter Sales\n2) Yearly Sales");
                                        var storeAssisSale = Console.ReadLine();
                                        if (storeAssisSale == "1")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesAssisManagerIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter Assistant Manager's additional Quarterly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateAssisManagerQuartSales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                        else if (storeAssisSale == "2")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesAssisManagerIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter Assistant Manager's additional Yearly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateAssisManagerYearlySales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                    }
                                    else if(chooseSale == "4")
                                    {
                                        Console.WriteLine("Associate:\n1) Current Quarter Sales\n2) Yearly Sales");
                                        var assocSale = Console.ReadLine();
                                        if (assocSale == "1")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesAssociateIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter Associate's additional Quarterly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateAssociateYearlySales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales ");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                        else if(assocSale == "2")
                                        {
                                            Console.WriteLine("Enter Employee ID");
                                            var employeeID = Convert.ToInt32(Console.ReadLine());
                                            if (EmployeeRepository.DoesAssociateIdExist(employeeID) == false)
                                            {
                                                Console.WriteLine("This Employee does not exist");
                                                break;
                                            }
                                            Console.WriteLine("Enter Associate's additional Yearly Sales");
                                            decimal retailSales = Convert.ToDecimal(Console.ReadLine());
                                            StoreSales.UpdateAssociateYearlySales(employeeID, retailSales);
                                            Console.WriteLine();
                                            Console.WriteLine("Press Enter to Return to Main Menu or 1 to add more employee sales ");
                                            var enter = Console.ReadLine();
                                            if (enter.Equals(""))
                                                loop = false;
                                            else
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    loop = false;
                                    break;
                            }
                        }
                        break;
                    case "2":
                        //Generate District Report
                        Console.WriteLine("District Sales Report. Please enter District Name:");
                        var districtName = Console.ReadLine();
                        var districtRepo = new DistrictRepository();
                        var district = districtRepo.GetDistrict(districtName); 
                        Console.WriteLine("District Sales Report");
                        Console.WriteLine();
                        foreach (var store in district.StoreList)
                        {
                            var retailYearly = 0m;
                            var retailCurrQtr = 0m;
                            Console.WriteLine($"Store #{store.StoreNumber}");
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("1. Store Manager");
                            foreach (var storeManager in store.StoreManagerList)
                            {
                                retailYearly += storeManager.AnnualRetailSales;
                                retailCurrQtr += storeManager.CurrQtrRetailSales;
                                Console.WriteLine($"   {storeManager.FirstName} {storeManager.LastName}:");
                                Console.WriteLine($"     Current Qtr Retail Sales: {string.Format("{0:C}", storeManager.CurrQtrRetailSales)}");
                                Console.WriteLine($"     Annual Retail Sales: {string.Format("{0:C}", storeManager.AnnualRetailSales)}");
                                Console.WriteLine();
                            }
                            Console.WriteLine("2. Assistant Manager");
                            foreach (var assistantManager in store.AssistantManagerList)
                            {
                                retailYearly += assistantManager.AnnualRetailSales;
                                retailCurrQtr += assistantManager.CurrQtrRetailSales;
                                Console.WriteLine($"   {assistantManager.FirstName} {assistantManager.LastName}:");
                                Console.WriteLine($"     Current Qtr Retail Sales: {string.Format("{0:C}", assistantManager.CurrQtrRetailSales)}");
                                Console.WriteLine($"     Annual Retail Sales: {string.Format("{0:C}", assistantManager.AnnualRetailSales)}");
                                Console.WriteLine();
                            }
                            Console.WriteLine("3. Associate");
                            foreach (var associate in store.AssociateList)
                            {
                                retailYearly += associate.AnnualRetailSales;
                                retailCurrQtr += associate.CurrQtrRetailSales;
                                Console.WriteLine($"   {associate.FirstName} {associate.LastName}:");
                                Console.WriteLine($"     Current Qtr Retail Sales: {string.Format("{0:C}", associate.CurrQtrRetailSales)}");
                                Console.WriteLine($"     Annual Retail Sales: {string.Format("{0:C}", associate.AnnualRetailSales)}");
                                Console.WriteLine();
                            }
                            Console.WriteLine($"Gas Yearly: {string.Format("{0:C}", store.YearlyGasSales)}");
                            Console.WriteLine($"Gas Current Quarter: {string.Format("{0:C}", store.CurrentQuarterGasSales)}");
                            Console.WriteLine($"Retail Yearly: {string.Format("{0:C}", retailYearly)}");
                            Console.WriteLine($"Retail Current Quarter: {string.Format("{0:C}", retailCurrQtr)}");
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        //Add New Employee
                        Console.WriteLine("Add a new employee.");
                        Console.WriteLine("Would you like to add an (1) Associate, (2) Assistant Manager, or (3) Store Manager? (Enter 1, 2, or 3)");
                        string selectType = Console.ReadLine();
                        if (selectType == "1")
                        {
                            Console.WriteLine("You chose Associate.");
                            Console.WriteLine("Enter employee First Name.");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter employee Last Name.");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Set employee's EmployeeId.");
                            string employeeId = Console.ReadLine();
                            int employeeIdInt = Convert.ToInt32(employeeId);
                            var employee = new Associate()
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                EmployeeID = employeeIdInt,
                                CurrQtrRetailSales = 0,
                                AnnualRetailSales = 0,
                            };
                            var repo = new EmployeeRepository();
                            repo.AddAssociate(employee);
                            Console.WriteLine("Select Store# to assign Associate to. (Enter number)");
                            var storeNum = Console.ReadLine();
                            int storeNumInt = Convert.ToInt32(storeNum);
                            var storeRepo = new StoreRepository();
                            storeRepo.AddAssociateToStore(storeNumInt, employee);
                            Console.WriteLine($"You added {employee.FirstName} {employee.LastName} with Associate ID {employee.EmployeeID} to Store#{storeNumInt}.");
                            Console.WriteLine();
                            break;
                        }
                        else if (selectType == "2")
                        {
                            Console.WriteLine("You chose Assistant Manager.");
                            Console.WriteLine("Enter employee First Name.");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter employee Last Name.");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Set employee's EmployeeId.");
                            string employeeId = Console.ReadLine();
                            int employeeIdInt = Convert.ToInt32(employeeId);
                            var employee = new AssistantManager()
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                EmployeeID = employeeIdInt,
                                CurrQtrRetailSales = 0,
                                AnnualRetailSales = 0,
                            };
                            var repo = new EmployeeRepository();
                            repo.AddAssistantManager(employee);
                            Console.WriteLine("Select Store# to assign Assistant Manager to. (Enter number)");
                            var storeNum = Console.ReadLine();
                            int storeNumInt = Convert.ToInt32(storeNum);
                            var storeRepo = new StoreRepository();
                            storeRepo.AddAssistantManagerToStore(storeNumInt, employee);
                            Console.WriteLine($"You added {employee.FirstName} {employee.LastName} with Assistant Manager ID {employee.EmployeeID} to Store#{storeNumInt}.");
                            Console.WriteLine();
                            break;
                        }
                        else if (selectType == "3")
                        {
                            Console.WriteLine("You chose Store Manager.");
                            Console.WriteLine("Enter employee First Name.");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter employee Last Name.");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Set employee's EmployeeId.");
                            string employeeId = Console.ReadLine();
                            int employeeIdInt = Convert.ToInt32(employeeId);
                            var employee = new StoreManager()
                            {
                                FirstName = firstName,
                                LastName = lastName,
                                EmployeeID = employeeIdInt,
                                CurrQtrRetailSales = 0,
                                AnnualRetailSales = 0,
                            };
                            var repo = new EmployeeRepository();
                            repo.AddStoreManager(employee);
                            Console.WriteLine("Select Store# to assign Store Manager to. (Enter number)");
                            var storeNum = Console.ReadLine();
                            int storeNumInt = Convert.ToInt32(storeNum);
                            var storeRepo = new StoreRepository();
                            storeRepo.AddStoreManagerToStore(storeNumInt, employee);
                            Console.WriteLine($"You added {employee.FirstName} {employee.LastName} with Store Manager ID {employee.EmployeeID} to Store#{storeNumInt}.");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You didn't enter 1, 2, or 3.");
                            break;
                        }
                    case "4":
                        //Add a Store/District
                        var storeSubMenu = "1) Add a District\n2) Add a Store";
                        Console.WriteLine(storeSubMenu);
                        var UserInputDistrictOrStore = Console.ReadLine();
                        switch (UserInputDistrictOrStore)
                        {
                            case "1": //Add District
                                var newDistrictRepo = new DistrictRepository();
                                var storeRepoForDistricts = new StoreRepository();
                                var allStores = storeRepoForDistricts.GetStores();

                                Console.WriteLine("Enter the new district's name");

                                var districtNameInput = Console.ReadLine();
                                if (newDistrictRepo.DoesDistrictNameExist(districtNameInput))
                                {
                                    Console.WriteLine($"{districtNameInput} already exists... please Enter to start over");
                                    Console.ReadKey();
                                    break;
                                }

                                Console.WriteLine("Available Stores to Add");
                                foreach (var eachStore in allStores)
                                {
                                    var chooseStoreNumber = eachStore.StoreNumber;
                                    Console.WriteLine($"Store Number: { chooseStoreNumber}");
                                }

                                //set up the stuff that needs to be shared across iterations first before loop
                                var districtStoreList = new List<StoreBase>();

                                Console.WriteLine("Choose store(s) to add to your new District or type '0' to continue...");
                                
                                while (true)
                                {
                                    var districtStoreNumberInput = Convert.ToInt32(Console.ReadLine());
                                    if (districtStoreNumberInput == 0)
                                    {
                                        break;
                                    }
                                    var storeToAddToList = storeRepoForDistricts.GetSingleStore   (districtStoreNumberInput);
                                    districtStoreList.Add(storeToAddToList);
                                }
                                Console.WriteLine("To choose the district manager, enter their EmployeeID...");
                                var districtEmployeeRepo = new EmployeeRepository();
                                var districtManagerList = new List<DistrictManager>();
                                var allDistrictManagers = districtEmployeeRepo.GetAllDistrictManagers();
                                foreach (var distMgr in allDistrictManagers)
                                {
                                    Console.WriteLine($"ID# {distMgr.EmployeeID}: {distMgr.FirstName} {distMgr.LastName}");
                                }

                                var chosenDistrictManagerId = Convert.ToInt32(Console.ReadLine());
                                var chosenDisrictManger = districtEmployeeRepo.GetDistrictManager(chosenDistrictManagerId);
                                districtManagerList.Add(chosenDisrictManger);

                                var newDistrict = new DistrictBase()
                                {
                                    DistrictName = districtNameInput,
                                    StoreList = districtStoreList,
                                    DistrictManager = districtManagerList
                                };
                                newDistrictRepo.AddNewDistrict(newDistrict);
                                Console.WriteLine($"Added a new District called {newDistrict.DistrictName}.");
                                    //$"\n District Manager: {newDistrict.DistrictManager}");
                                break;

                            case "2": //Add Store
                                var storeRepo = new StoreRepository();
                                Console.WriteLine("Create a store ID number, e.g. 001");
                                var storeNumberInput = Convert.ToInt32(Console.ReadLine());
                                if (StoreRepository.DoesStoreIdAlreadyExist(storeNumberInput) == true)
                                {
                                    Console.WriteLine($"{storeNumberInput} already exists... please Enter to start over");
                                    Console.ReadKey();
                                    break;
                                }

                                Console.WriteLine("Enter Yearly Gas Sales");
                                var storeYearlyGasSales = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Enter Current Quarter Gas Sales");
                                var storeCurrentQtrGasSales = Convert.ToDecimal(Console.ReadLine());

                                var store = new StoreBase()
                                {
                                    StoreNumber = storeNumberInput,
                                    YearlyGasSales = storeYearlyGasSales,
                                    CurrentQuarterGasSales = storeCurrentQtrGasSales,
                                    District = new DistrictBase(),
                                    StoreManagerList = new List<StoreManager>(),
                                    AssistantManagerList = new List<AssistantManager>(),
                                    AssociateList = new List<Associate>()
                                };
                                storeRepo.Add(store);
                                Console.WriteLine($"You added Store #{storeNumberInput}.");
                                Console.ReadKey();

                                break;
                            default:
                                DisplayMenu();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Goodbye");
                        loopControl = false;
                        break;
                }

            }




        }
    }
}
