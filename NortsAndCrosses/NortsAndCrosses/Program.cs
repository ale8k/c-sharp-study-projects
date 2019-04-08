using System;

namespace NortsAndCrosses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string playersInput;
            int playersTurn = 1;

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
                        if (game != null)
                        {
                            game.UpdatePlayersMap(playersTurn);
                            Console.WriteLine($"player {playersTurn} just had a play");
                            playersTurn = playersTurn == 1 ? 2 : 1;
                            Console.WriteLine($"it is now player {playersTurn} turn");
                        }
                        break;
                }
            }

        }
    }
}
