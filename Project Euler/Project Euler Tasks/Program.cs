using System;
using System.Collections.Generic;
using Project_Euler_Tasks.Tasks;
using Project_Euler_Tasks.Interfaces;

namespace Project_Euler_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int usersInput;
            List<ITask> myTasks = GetTaskList();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Currently there are {myTasks.Count} complete of 657");
                Console.WriteLine("Enter a task number to run that task:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                usersInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                RunTask(usersInput, myTasks);
                Console.WriteLine();
                Console.WriteLine("Press the enter/return key to continue...");
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void RunTask(int id, List<ITask> myTaskList)
        {
            foreach (ITask task in myTaskList)
            {
                if (task.TaskID == id)
                    task.ShowInfo().Run();
            }

        }

        private static List<ITask> GetTaskList()
        {
            List<ITask> list = new List<ITask>()
            {
                new Task1(),
                new Task2(),
                new Task3(),
                new Task4(),
                new Task5()
            };

            return list;
            
        }

    }

}
