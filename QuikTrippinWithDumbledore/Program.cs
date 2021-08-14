using System;
using System.Collections.Generic;
using QuikTrippinWithDumbledore.Store;

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

            var loopControl = true;
            while (loopControl)
            {
                DisplayMenu();
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Enter District Sales
                        
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
                        Console.WriteLine("1) Add a District\n2) Add a Store\n3) Main Menu");
                        var UserInputDistrictOrStore = Console.ReadLine();
                        switch (UserInputDistrictOrStore)
                        {
                            case "1": //Add District
                                Console.WriteLine("Add");
                                break;
                            case "2": //Add Store
                                Console.WriteLine("Create a Store Number");
                                var storeNumber = Console.ReadLine();
                                Console.WriteLine("Add Yearly Gas Sales");
                                var storeYearlyGasSales = Console.ReadLine();
                                Console.WriteLine("Add");

                                var storeRepo = new StoreRepository();
                                //var createStore = storeRepo.Add()
                                

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
