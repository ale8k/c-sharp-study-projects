using System;

namespace NortsAndCrosses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to norts and crosses, the commands are:");
            Console.WriteLine("'xo start', 'xo end' and 'xo restart'.");
            Console.WriteLine("To play the game, enter the corresponding number from the matrix. Have fun!");

            Game game = null;
            string playersInput = "0";
            int playersTurn = 1;
            bool hasBeenSaidOnce = false;

            while (true)
            {
                /*
                 * Current turn message: only displayed if game is active.
                 */
                if (game != null && !hasBeenSaidOnce)
                {
                    Console.Clear();
                    Console.WriteLine($"It is player {playersTurn}'s turn");
                    hasBeenSaidOnce = true;
                    game.GetCurrentGameMapState();
                }
                else if (game != null && hasBeenSaidOnce && game.ValidatePlayersInput(playersInput))
                {
                    Console.Clear();
                    Console.WriteLine($"It is now player {playersTurn}'s turn");
                    game.GetCurrentGameMapState();
                }
                else if(game != null && hasBeenSaidOnce && !game.ValidatePlayersInput(playersInput))
                {
                    Console.Clear();
                    Console.WriteLine($"It is still player {playersTurn}'s turn, they entered wrong input");
                    game.GetCurrentGameMapState();
                }

                /*
                 * Get input from user
                 */
                Console.WriteLine();
                playersInput = Console.ReadLine();

                /*
                 * Test input against commands & the game itself
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
                            // remove from game map
                            // add to players map
                            // test players map for success
                            // switch to other player on end
                            playersTurn = playersTurn == 1 ? 2 : 1;
                        }
                        break;
                }
            }

        }
    }
}
