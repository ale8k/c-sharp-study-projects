using System;
using System.Text;

namespace XsAndOs.Entities.GameMap
{
    public class Map
    {
        private StringBuilder _gameMapBuilder;
        private string _gameMap;

        public Map()
        {
            Console.Clear();
            Console.WriteLine("Game started, please enter corresponding number to place your x or o");
            CreateGameMap();
        }

        private void CreateGameMap()
        {
            _gameMapBuilder = new StringBuilder();

            _gameMapBuilder
                .AppendLine()
                .Append("  1  |  2  |  3  ")
                .AppendLine()
                .Append("________________")
                .AppendLine()

                .AppendLine()
                .Append("  4  |  5  |  6  ")
                .AppendLine()
                .Append("________________")
                .AppendLine()

                .AppendLine()
                .Append("  7  |  8  |  9  ");

            _gameMap =_gameMapBuilder.ToString();
            Console.WriteLine(_gameMap);
        }

        public string UpdateMap()
        {
            Console.Clear();
            return _gameMap;
        }
    }
}
