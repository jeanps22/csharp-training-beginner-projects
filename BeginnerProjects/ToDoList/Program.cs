using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static List<string> taskList = new List<string>();
        static void Main(string[] args)
        {
            string menuResponse = "";
            Console.WriteLine("Welcome to the To Do List!");
            while (menuResponse != "0")
                menuResponse = StartMenu();

            Console.ReadKey();
        }

        static string StartMenu()
        {
            string userChoice;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 - Add new Task");
            Console.WriteLine("2 - Remove a Task");
            Console.WriteLine("3 - View the Task List");
            Console.WriteLine("0 - Exit the program");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    AddTask();
                    return userChoice;
                case "2":
                    RemoveTask();
                    return userChoice;
                case "3":
                    ViewTaskList();
                    return userChoice;
                case "0":
                    return userChoice;
                default:
                    Console.WriteLine("Unrecognized option");
                    return userChoice;
            }
        }

        static void AddTask()
        {
            string taskDescription = Console.ReadLine();

            taskList.Add(taskDescription);
        }

        static void ViewTaskList()
        {
            for (int index = 0; index < taskList.Count; index++)
            {
                string task = taskList[index];
                Console.WriteLine($"{index} - {task}");
            }
        }

        static void RemoveTask()
        {
            int taskNumber = 0;
            Console.WriteLine("Which Task do you want to remove?");
            ViewTaskList();
            taskNumber = Convert.ToInt32(Console.ReadLine());

            if (taskList.Count >= taskNumber)
            {
                taskList.RemoveAt(taskNumber);
                Console.WriteLine("The third task has been removed.");
            }
            else
            {
                Console.WriteLine("The list does not contain this Task.");
            }
        }
    }
}
