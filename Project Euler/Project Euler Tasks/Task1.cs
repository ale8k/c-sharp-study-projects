using System;

namespace Project_Euler_Tasks
{
    public class Task1 : ITask
    {
        private int _taskId = 1;

        public void Run()
        {
            Console.WriteLine("working");
            Console.ReadLine();
        }

        public int TaskID
        {
            get
            {
                return _taskId;
            }
        }

    }


}
