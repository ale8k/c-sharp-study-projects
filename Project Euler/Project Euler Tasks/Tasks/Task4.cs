using System;
using Project_Euler_Tasks.Interfaces;

namespace Project_Euler_Tasks.Tasks
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
