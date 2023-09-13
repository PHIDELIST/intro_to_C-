using System;
namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("weolcome to the todod list");
            List<string> tasklist = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do");
                Console.WriteLine("Enter 1 to add task to the list. ");
                Console.WriteLine("Enter 2 to remove a task from the list. .");
                Console.WriteLine("Enter 3 to view the list .");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("enter the name of task you would like to add to the list");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("Item was successfully adde to the list");

                }
                else if (option == "2")
                {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + ":" + tasklist[i]);
                    }
                    Console.WriteLine("Please enter the number od the task to remove from the list .");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);
                }
                else if(option == "3") 
                {
                    Console.WriteLine("Current tasks available are ");
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);

                    }
                }else if(option == "e")
                {
                    Console.WriteLine("Exiting the program");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            Console.WriteLine("Thank you for using the program");
        }
    }
   
}