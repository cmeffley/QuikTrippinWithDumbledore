﻿using QuikTrippinWithDumbledore.Employee;
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
                            Console.WriteLine($"You added {employee.FirstName} {employee.LastName} with Associate ID {employee.EmployeeID}.");
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
                            Console.WriteLine($"You added {employee.FirstName} {employee.LastName} with Assistant Manager ID {employee.EmployeeID}.");
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
                            Console.WriteLine($"You added {employee.FirstName} {employee.LastName} with Store Manager ID {employee.EmployeeID}.");
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
