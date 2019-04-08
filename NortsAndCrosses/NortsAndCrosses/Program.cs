using System;

namespace NortsAndCrosses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string playersInput;
            int playersTurn;

            while (true)
            {
                playersInput = Console.ReadLine();

                switch (playersInput.ToLower())
                {
                    case "xo start":
                        game = new Game();
                        Console.WriteLine("Game started.");
                        break;

                    case "xo end":
                        game = null;
                        Console.WriteLine("Game ended.");
                        break;

                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        if (game != null && game.ValidatePlayersInput(playersInput))
                            Console.WriteLine("properly validated, good shit");
                        break;
                }
            }

        }
    }
}
