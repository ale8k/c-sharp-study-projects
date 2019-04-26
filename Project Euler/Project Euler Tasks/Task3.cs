using System;

namespace Project_Euler_Tasks
{
    public class Task3 : ITask
    {
        public int TaskID { get; } = 3;

        public ITask ShowInfo()
        {
            Console.WriteLine("Largest prime factor:");

            return this;
        }
        
       
        public void Run()
        {

            Console.WriteLine(Int64.MaxValue);
        }
    }
}
