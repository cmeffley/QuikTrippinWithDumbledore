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
                Console.WriteLine("2) Update Retail Sales");
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
                                    Console.WriteLine("Enter Store Number");
                                    int storeNumber = Convert.ToInt32(Console.ReadLine());
                                    var store = StoreRepository.GetSingleStore(storeNumber);
                                    Console.WriteLine($@"Store #{storeNumber} \n{store.CurrentQuarterGasSales}");
                                    //Console.WriteLine($"{store.CurrentQuarterGasSales}");
                                    Console.WriteLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Employee Position");
                                    int employeePosition = Convert.ToInt32(Console.ReadLine());
                                    
                                    
                                    break;
                                default:
                                    loop = false;
                                    break;
                            }
                        }
                        break;
                    case "2":
                        //Generate District Report
                        Console.WriteLine("Test 2");
                        break;
                    case "3":
                        //Add New Employee
                        Console.WriteLine("Test 3");
                        break;
                    case "4":
                        //Add a Store/District
                        Console.WriteLine("1) Add a District\n2)Add a Store\n3) Main Menu");
                        var UserInputDistrictOrStore = Console.ReadLine();
                        switch (UserInputDistrictOrStore)
                        {
                            case "1": //Add District
                                Console.WriteLine("Add");
                                break;
                            case "2": //Add Store

                                break;
                            default:
                                DisplayMenu();
                                break;
                        }
                        break;
                        ////////////////////////
                    default:
                        Console.WriteLine("Goodbye");
                        loopControl = false;
                        break;
                }

            }




        }
    }
}
