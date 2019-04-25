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
            List<ITask> myTasks = new List<ITask>();
            myTasks.Add(new Task1());
            Console.WriteLine($"Currently there are {myTasks.Count} complete of 657");
            Console.WriteLine();
            RunTask(1, myTasks);
        }

        public static void RunTask(int id, List<ITask> myTaskList)
        {
            foreach(ITask task in myTaskList)
            {
                if (task.TaskID == id)
                    task.ShowInfo().Run();
            }

        }

    }

}
