using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myStopwatch = new Stopwatch();

            myStopwatch.Start();
            myStopwatch.Stop();
            Class1.Talk();
            Console.ReadLine();
        }
    }
}
