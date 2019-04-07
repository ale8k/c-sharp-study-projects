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
            CreateGameMap();
        }

        private void CreateGameMap()
        {
            _gameMapBuilder = new StringBuilder();

            _gameMapBuilder
                .Append("Enter a number corresponding with the position you'd like to replace with an x or o.")
                .AppendLine()
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
                .Append("  7  |  8  |  9  ")
                .AppendLine()
                .AppendLine();


            _gameMap =_gameMapBuilder.ToString();
            Console.WriteLine(_gameMap);
        }
        public string GetMapString()
        {
            Console.Clear();
            return _gameMap;
        }
    }
}
