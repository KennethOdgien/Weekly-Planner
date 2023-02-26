using System;
using System.Collections.Generic;

namespace Odgien
{
    class Program
    {
        /*
         Odgien Kenneth N.
         BSIT 2-1
        */
        static void UI()
        {
            Console.WriteLine("************************************\n");
            Console.WriteLine("---WELCOME TO YOUR WEEKLY PLANNER---");
            Console.WriteLine("\n************************************ \n");

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Modify your plan on a specific day [Add/Remove]");
            Console.WriteLine("[2] View your plan on a specific day");
            Console.WriteLine("[3] View all your plans for the week");
            Console.WriteLine("[4] Exit");
        }

        static void Menu()
        {
            Console.WriteLine("What day:");
            Console.WriteLine("[MONDAY], [TUESDAY], [WEDNESDAY], [THURSDAY], [FRIDAY], [SATURDAY], [SUNDAY]");
        }

        static void Main(string[] args)
        {
            List<string> Mon = new List<string>();
            List<string> Tue = new List<string>();
            List<string> Wed = new List<string>();
            List<string> Thu = new List<string>();
            List<string> Fri = new List<string>();
            List<string> Sat = new List<string>();
            List<string> Sun = new List<string>();
            int userin;
            do
            {
                UI();
                string plan, input;

                userin = Convert.ToInt32(Console.ReadLine());

                // Modifying Plans, Add & Remove

                if (userin == 1)
                {
                    Menu();
                    input = Console.ReadLine();
                    if (input.Equals("Monday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Mon.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Mon.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }
                    }
                    else if (input.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Tue.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Tue.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }
                    }
                    else if (input.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Wed.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Wed.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }
                    }
                    else if (input.Equals("Thursday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Thu.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Thu.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }

                    }
                    else if (input.Equals("Friday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Fri.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Fri.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }
                    }
                    else if (input.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Sat.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Sat.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }
                    }
                    else if (input.Equals("Sunday", StringComparison.OrdinalIgnoreCase))
                    {
                        string choice;
                        Console.WriteLine("Would you like to ADD or REMOVE a plan/schedule?");
                        choice = Console.ReadLine();

                        if (choice == "add" || choice == "Add" || choice == "ADD")
                        {
                            Console.WriteLine("Enter your Plan/Schedule");
                            plan = Console.ReadLine();
                            Sun.Add(plan);
                            Console.WriteLine("Your Plan / Schedule is successfully added!");
                        }
                        else if (choice == "Remove" || choice == "remove" || choice == "REMOVE")
                        {
                            Console.WriteLine("What Plan/Schedule would you like to remove?");
                            plan = Console.ReadLine();
                            Sun.Remove(plan);
                            Console.WriteLine("Your Plan / Schedule was successfully removed.");
                        }
                    }
                }

                // Viewing Schedule on a specific day

                else if (userin == 2)
                {
                    Menu();
                    input = Console.ReadLine();
                    if (input.Equals("Monday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Monday:");
                        foreach (var plans in Mon)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                    else if (input.Equals("Tuesday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Tuesday:");
                        foreach (var plans in Tue)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                    else if (input.Equals("Wednesday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Wednesday:");
                        foreach (var plans in Wed)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                    else if (input.Equals("Thursday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Thursday:");
                        foreach (var plans in Thu)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                    else if (input.Equals("Friday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Friday:");
                        foreach (var plans in Fri)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                    else if (input.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Saturday:");
                        foreach (var plans in Sat)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                    else if (input.Equals("Sunday", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Here is your plans / schedule for Sunday:");
                        foreach (var plans in Sun)
                        {
                            Console.WriteLine(plans);
                        }
                    }
                }

                else if(userin == 3)
                {
                    Console.WriteLine("Here is your plans / schedule for the week:");
                    Console.WriteLine("\nMONDAY: ");
                    foreach (var plans in Mon)
                    {
                        Console.WriteLine(plans);
                    }
                    Console.WriteLine("\nTUESDAY: ");
                    foreach (var plans in Tue)
                    {
                        Console.WriteLine(plans);
                    }
                    Console.WriteLine("\nWEDNESDAY: ");
                    foreach (var plans in Wed)
                    {
                        Console.WriteLine(plans);
                    }
                    Console.WriteLine("\nTHURSDAY: ");
                    foreach (var plans in Thu)
                    {
                        Console.WriteLine(plans);
                    }
                    Console.WriteLine("\nFRIDAY: ");
                    foreach (var plans in Fri)
                    {
                        Console.WriteLine(plans);
                    }
                    Console.WriteLine("\nSATURDAY: ");
                    foreach (var plans in Sat)
                    {
                        Console.WriteLine(plans);
                    }
                    Console.WriteLine("\nSUNDAY: ");
                    foreach (var plans in Sun)
                    {
                        Console.WriteLine(plans);
                    }
                }
                else if (userin == 4)
                {
                    break;
                }
            }
            while (userin == 1 || userin == 2 || userin == 3);
        }
    }
}
