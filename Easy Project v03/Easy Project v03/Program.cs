using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Project_v03
{
    //--------------------------------------------------------
    /* This project made by Anar Abasov
    * To-Do List: Develop a console-based to-do list application where users can add, edit, and remove tasks.*/
    //--------------------------------------------------------

    internal class Program
    {
        static List<string> Task = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose option for To-Do List");
                Console.WriteLine("\t1.Add task");
                Console.WriteLine("\t2.Edit task");
                Console.WriteLine("\t3.Remove task");
                Console.WriteLine("\t4.View task");
                Console.WriteLine("\t5.Exit");

                Console.Write("Selet on option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        taskAdd();
                        break;
                    case "2":
                        taskView();
                        break;
                    case "3":
                        taskRemove();
                        break;
                    case "4":
                        taskView();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            }
        }
        static void taskView()
        {
            Console.Clear();

            Console.WriteLine("Tasks...");
            if(Task.Count == 0)
            {
                Console.WriteLine("Not found any task");
            }
            else
            {
                for (int i = 0; i < Task.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Task[i]}");
                }
            }

        }

        static void taskAdd()
        {
            Console.Clear();
            Console.Write("Enter the task content...");
            string task = Console.ReadLine();

            Task.Add(task);

            Console.WriteLine("Task added Successfully!");
        }

        static void taskEdit()
        {
            taskView();
            Console.WriteLine("Choose task number");
            int taskNum = int.Parse(Console.ReadLine()) - 1;    

            if(taskNum >= 0 && taskNum < Task.Count)
            {
                Console.WriteLine("Enter the new tasks content");
                string newtaskContent = Console.ReadLine();
                Task[taskNum] = newtaskContent;
                Console.WriteLine("Task Edited Sccessfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number, Try again");
            }
        }
        
        static void taskRemove()
        {
            taskView();
            Console.Write("Choose task number");
            int taskNum = int.Parse (Console.ReadLine()) - 1;   

            if( taskNum >= 0 && taskNum < Task.Count)
            {
                Task.RemoveAt(taskNum);
                Console.Write("Task removed successfully!");
            }
            else
            {
                Console.Write("Invalid task number, Try again");
            }
        }
    }
}
