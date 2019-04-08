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
            Player player1 = null;
            Player player2 = null;
            string playersInput = "0";
            int playersTurn = 1;
            string message = "";
            int usersIntInput;

            while (true)
            {
                /*
                 * Current turn message
                 */
                if (game != null && game.ValidatePlayersInput(playersInput))
                {
                    Console.WriteLine($"It is now player {playersTurn}'s turn");
                    Console.WriteLine(message);
                    game.PrintGameMap();
                    // printing player map
                    Console.WriteLine();
                    player1.PrintPlayersMap();
                    Console.WriteLine();
                    player2.PrintPlayersMap();
                }
                else if(game != null && !game.ValidatePlayersInput(playersInput))
                {
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
                        player1 = game.GetPlayer(1);
                        player2 = game.GetPlayer(2);
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
                            usersIntInput = Convert.ToInt32(playersInput);

                            if (!game.GetGameMap().Contains(usersIntInput))
                            {
                                message = "Error: the value you entered has already been entered";
                            }
                            else
                            {
                                message = "";
                                game.GetGameMap().Remove(usersIntInput);

                                if (playersTurn == player1.PlayerID)
                                    player1.PlayersMap.Add(usersIntInput);
                                else if(playersTurn == player2.PlayerID)
                                    player2.PlayersMap.Add(usersIntInput);

                                playersTurn = playersTurn == 1 ? 2 : 1;
                            }
                        }
                        break;
                }
            }

        }
    }
}
