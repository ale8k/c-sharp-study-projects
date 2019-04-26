﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            long num = 600851475143;
            int factor = 3;

            while (num > 1)
            {
                if (num % factor == 0)
                    num /= factor;
                else
                    factor += 2;
            }

        }
    }

}
