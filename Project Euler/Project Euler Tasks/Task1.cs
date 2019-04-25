using System;

namespace Project_Euler_Tasks
{
    public class Task1 : ITask
    {
        private int _taskId = 1;

        public ITask ShowInfo()
        {
            Console.WriteLine("Multiples of 3 and 5:");
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            return this;
        }

        public void Run()
        {
            RunTask1();
            Console.ReadLine();
        }
        public int TaskID
        {
            get
            {
                return _taskId;
            }
        }
        public void RunTask1()
        {
            

        }


    }


}
