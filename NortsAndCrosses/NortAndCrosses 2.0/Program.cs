using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> main = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int playersTurn = 1;

            while(true)
            {
                Console.WriteLine("Main has:");
                foreach (int i in main)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.Write("List1 has:");
                foreach (int i in list1)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                Console.Write("List2 has:");
                foreach (int i in list2)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
                int userInput = Convert.ToInt32(Console.ReadLine());

                main.Remove(userInput);

                if (playersTurn == 1)
                    list1.Add(userInput);
                else
                    list2.Add(userInput);

                playersTurn = playersTurn == 1 ? 2 : 1;
                Console.Clear();
                // all conditions about checking winner, if main is empty are here
                /*  123 456 789 
                 *  147 258 369
                 *  357     159
                 *  Sequences
                 */

            }
        }
    }
}
