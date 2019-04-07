using System;

namespace Maze
{
    public class GameInstance
    {

        public DateTime GameStarted = DateTime.Now;

        public bool GameIsActive { get; set; }
        private int _arrayAmount;
        private int _arrayLength;

        public GameInstance(bool activeOrNot, int lanes, int howLong)
        {
            GameIsActive = activeOrNot;
            _arrayAmount = lanes;
            _arrayLength = howLong;

            int[,] y = CreateGameArray(_arrayAmount, _arrayLength);
            FillArray(y);

        }

        public int[,] CreateGameArray(int lanes, int howLong)
        {
            int arrayAmount = lanes;
            int arrayLength = howLong;

            int[,] gameArray = new int[arrayAmount, arrayLength];
                                        // { 
                                        //   {1,2,3}
                                        //   {1,2,3}
                                        //   {1,2,3}     
                                        // }
            return gameArray;
        }

        public void FillArray(int[,] array)
        {
            for (int i = 0; i < _arrayAmount; i++)
            {
                for (int j = 0; j < _arrayLength; j++)
                {
                    array[i, j] = j + 1;
                }
            }
        }

    }
}
