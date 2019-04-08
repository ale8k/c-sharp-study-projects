using System;

namespace NortsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string playersInput;
            int playerID;

            while(true)
            {
                playersInput = Console.ReadLine();
                /*
                 * Handles commands outside of the game
                 */
                switch(playersInput.ToLower())
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
                if(game != null)
                {
                    playerID = game.GetPlayersTurn();
                    Console.WriteLine($"It is player {playerID}'s turn");

                    while(game.ValidatePlayersInput(playersInput) != true)
                    {

                    }
                }

            }

        }
    }
}
