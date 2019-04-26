using System;
using Project_Euler_Tasks.Interfaces;

namespace Project_Euler_Tasks.Tasks
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