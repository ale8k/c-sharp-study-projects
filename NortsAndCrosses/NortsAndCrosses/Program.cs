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
                }

                if (game != null && game.ValidatePlayersInput(playersInput) == true)
                {
                    Console.WriteLine("validated successfully");
                    playersTurn = game.GetPlayersTurn();
                    Console.WriteLine($"it is now player {playersTurn}'s turn");
                }
            }

        }
    }
}
