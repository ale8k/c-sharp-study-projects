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
            string message = "";

            while (true)
            {
                /*
                 * Current turn message
                 */
                if (game != null && game.ValidatePlayersInput(playersInput))
                {
                    Console.Clear();
                    Console.WriteLine($"It is now player {playersTurn}'s turn");
                    Console.WriteLine(message);
                    game.PrintGameMap();
                }
                else if(game != null && !game.ValidatePlayersInput(playersInput))
                {
                    Console.Clear();
                    Console.WriteLine($"It is now player {playersTurn}'s turn");
                    Console.WriteLine("Error: the value you entered in not validatable ");
                    game.PrintGameMap();
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
                            int usersIntInput = Convert.ToInt32(playersInput);

                            if (!game.GetGameMap().Contains(usersIntInput))
                            {
                                message = "Error: the value you entered has already been entered";
                            }
                            else
                            {
                                message = "";
                                game.GetGameMap().Remove(usersIntInput);
                                game.GetPlayer(playersTurn).PlayersMap.Add(usersIntInput); // gets player object, based on turn flipper
                                
                                playersTurn = playersTurn == 1 ? 2 : 1;
                            }
                        }
                        break;
                }
            }

        }
    }
}
