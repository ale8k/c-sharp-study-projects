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

            List<ITask> myTasks = new List<ITask>();
            myTasks.Add(new Task1());
            myTasks.Add(new Task2());

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

    }

}
