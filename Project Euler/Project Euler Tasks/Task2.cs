using System;

namespace Project_Euler_Tasks
{
    public class Task2 : ITask
    {
        public int TaskID { get; } = 2;

        public ITask ShowInfo()
        {
            Console.WriteLine("task 2:");
            return this;
        }

        public void Run()
        {
            Console.ReadLine();
        }


    }
}
