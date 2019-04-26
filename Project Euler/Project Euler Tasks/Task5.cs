using System;

namespace Project_Euler_Tasks
{
    public class Task5 : ITask
    {
        public int TaskID { get; } = 5;

        public ITask ShowInfo()
        {
            Console.WriteLine("A Task:");

            return this;
        }

        public void Run()
        {
        }
    }
}