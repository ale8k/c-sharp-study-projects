using System;

namespace NortsAndCrosses
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string usersInput;

            while(true)
            {
                usersInput = Console.ReadLine();
                /*
                 * Handles commands outside of the game
                 */
                switch(usersInput.ToLower())
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
                    game.GetAndValidateUsersInput(usersInput);

            }

        }
    }
}
