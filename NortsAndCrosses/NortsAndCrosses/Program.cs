using System;

namespace NortsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string playersInput;
            int playersTurn;
            do
            {
                playersInput = Console.ReadLine();

                /*
                 * Handles commands outside of the game
                 */
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

                /*
                 * Listens for a game start
                 */
                if (game != null)
                {
                    playersTurn = game.GetPlayersTurn();
                    Console.WriteLine($"it is player {playersTurn}'s turn");

                    while (!game.ValidatePlayersInput(playersInput))
                    {
                        playersInput = Console.ReadLine();
                    }

                }

            } while (true);

        }
    }
}
