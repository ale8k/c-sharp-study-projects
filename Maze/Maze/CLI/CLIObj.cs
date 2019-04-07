using System;

namespace Maze.CLI
{
    class CLIObj
    {
        private GameInstance _gameInstance;
        private int gameTimer;

        public void Command(string usersInput)
        {
            string toLowerInput = usersInput.ToLower();

            switch(toLowerInput)
            {
                case "start":
                    Console.WriteLine("Please enter options for the game:");
                    Console.WriteLine("Enter amount of lanes (arrays)");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length of each lane (array size)");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    GameOptions(true, input1, input2);
                    Console.WriteLine($"Game options of {input1} lanes and {input2} length accepted.");
                    break;

                case "startedat":
                    gameTimer = (_gameInstance.GameStarted - DateTime.Now).Seconds;
                    Console.WriteLine(gameTimer);
                    break;
            }
        }

        public void GameOptions(bool activateGame, int lanes, int howLong)
        {
            _gameInstance = new GameInstance(activateGame, lanes, howLong);
        }
    }
}
