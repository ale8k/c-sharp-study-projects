using System;

namespace Project_Euler_Tasks
{
    public class Task4 : ITask
    {
        public int TaskID { get; } = 4;

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
