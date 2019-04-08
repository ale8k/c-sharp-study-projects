using System;

namespace NortsAndCrosses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = null;
            string playersInput = Console.ReadLine();
            int playersTurn;

            while (true)
            {
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

                while (game != null)
                {

                    playersInput = Console.ReadLine();
                    playersTurn = game.GetPlayersTurn();
                    Console.WriteLine($"it is player {playersTurn}'s turn");

                    while (!game.ValidatePlayersInput(playersInput))
                    {
                        playersInput = Console.ReadLine();
                    }
                    break;
                }
            }

        }
    }
}
