using System;
using System.Collections.Generic;
using Project_Euler_Tasks.Interfaces;

namespace Project_Euler_Tasks.Tasks
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


            List<long> primeList = GeneratePrimeList(GenerateListFor(100));

            foreach (long i in primeList)
            {
                Console.WriteLine(i);
            }

        }

        private List<long> GeneratePrimeList(List<long> list)
        {
            List<long> primeList = new List<long>();

            foreach (long i in list)
            {
                if (IsItPrime(i))
                    primeList.Add(i);
            }

            return primeList;
        }

        private bool IsItPrime(long num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

        }

        private List<long> GenerateListFor(long num)
        {
            List<long> list = new List<long>();

            for (long i = 2; i < num; i++)
            {
                list.Add(i);
            }
            return list;
        }

    }

}
