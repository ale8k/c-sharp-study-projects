using System;
using System.Collections.Generic;

namespace NortAndCrosses_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            GameInstance gi = new GameInstance();
            // below works, above ^ is attempts to move into gameinstance class

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> main = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            SequenceValidator sv = new SequenceValidator();
            string winner = "none";
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
                if (main.Count <= 6)
                    if (sv.ValidateSequence(list1))
                    {
                        Console.WriteLine("player 1 win");
                        winner = "player 1";
                    }
                    else if (sv.ValidateSequence(list2))
                    {
                        Console.WriteLine("player 2 win");
                        winner = "player 2";
                    }

                if(main.Count == 0 && winner == "none")
                    Console.WriteLine("draw");
            }
        }
    }
}
