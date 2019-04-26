using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Tasks
{

    class Program
    {
        static void Main(string[] args)
        {
            int usersInput;

            List<ITask> myTasks = GetTaskList();

            Console.WriteLine($"Currently there are {myTasks.Count} complete of 657");
            Console.WriteLine();
            Console.WriteLine("Enter a task number to run that task:");
            Console.WriteLine();

            while (true)
            {
                usersInput = Convert.ToInt32(Console.ReadLine());
                RunTask(usersInput, myTasks);
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
                new Task3()
            };

            return list;
            
        }

    }

}
