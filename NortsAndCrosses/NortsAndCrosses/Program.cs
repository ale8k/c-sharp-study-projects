using System;

namespace NortsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string playersInput;
            bool playerIDInitialised = false;
            int playerID = 0; // dont wanna do this, feels weird af

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
                    // mhm, thought maybe having a bool check would work...
                    if (playerIDInitialised == false)
                    {
                        playerID = game.GetPlayersTurn();
                        playerIDInitialised = true;
                    }

                    Console.WriteLine($"It is player {playerID}'s turn");

                    while (!game.ValidatePlayersInput(playersInput))
                    {
                        playersInput = Console.ReadLine();
                    }
                    Console.WriteLine("accepted input");
                    playerID = game.GetPlayersTurn();
                    Console.WriteLine($"it is now player {playerID}'s turn");
                }

            } while (playerIDInitialised);

        }
    }
}
