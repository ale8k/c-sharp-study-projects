using System;
using System.Collections.Generic;

namespace Project_Euler_Tasks
{
    public class Task1 : ITask
    {
        public int TaskID { get; } = 1;

        public ITask ShowInfo()
        {
            Console.WriteLine("Multiples of 3 and 5:");
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            return this;
        }

        public void Run()
        {
            List<int> numList = new List<int>();
            int sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    numList.Add(i);
            }
            foreach (int i in numList)
            {
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of all multiples of 3 and 5 in 1000 is {sum}");
            Console.ReadLine();
        }
    }
}
