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

            string _gameMap =_gameMapBuilder.ToString();
            Console.WriteLine(_gameMap);
        }
    }
}
