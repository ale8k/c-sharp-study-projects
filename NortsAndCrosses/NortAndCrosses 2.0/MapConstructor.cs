using System.Collections.Generic;
using System.Text;
using NortAndCrosses_2._0.Entities;

namespace NortAndCrosses_2._0
{
    public class MapConstructor
    {
        private StringBuilder sb;

        public MapConstructor()
        {
            sb = new StringBuilder();
            sb
                .Append(' ', 23).Replace(' ', '1', 3, 1).Replace(' ', '|', 7, 1).Replace(' ', '2', 11, 1).Replace(' ', '|', 15, 1).Replace(' ', '3', 19, 1)
                .AppendLine().Append('_', 23).AppendLine().AppendLine()
                .Append(' ', 23).Replace(' ', '4', 55, 1).Replace(' ', '|', 59, 1).Replace(' ', '5', 63, 1).Replace(' ', '|', 67, 1).Replace(' ', '6', 71, 1)
                .AppendLine().Append('_', 23).AppendLine().AppendLine()
                .Append(' ', 23).Replace(' ', '7', 107, 1).Replace(' ', '|', 111, 1).Replace(' ', '8', 115, 1).Replace(' ', '|', 119, 1).Replace(' ', '9', 123, 1).AppendLine();
        }

        public void Draw(List<int> map, IPlayer mainPlayer, IPlayer opponent)
        {
            System.Console.WriteLine(sb.ToString());
        }

        public void Update(IPlayer player)
        {
            switch(player.Input)
            {
                case 1:
                    if (player is IOpponent)
                        sb.Replace('1', 'X');
                    else
                        sb.Replace('1', 'O');
                    break;
                case 2:
                    if (player is IOpponent)
                        sb.Replace('2', 'X');
                    else
                        sb.Replace('2', 'O');
                    break;
                case 3:
                    if (player is IOpponent)
                        sb.Replace('3', 'X');
                    else
                        sb.Replace('3', 'O');
                    break;
                case 4:
                    if (player is IOpponent)
                        sb.Replace('4', 'X');
                    else
                        sb.Replace('4', 'O');
                    break;
                case 5:
                    if (player is IOpponent)
                        sb.Replace('5', 'X');
                    else
                        sb.Replace('5', 'O');
                    break;
                case 6:
                    if (player is IOpponent)
                        sb.Replace('6', 'X');
                    else
                        sb.Replace('6', 'O');
                    break;
                case 7:
                    if (player is IOpponent)
                        sb.Replace('7', 'X');
                    else
                        sb.Replace('7', 'O');
                    break;
                case 8:
                    if (player is IOpponent)
                        sb.Replace('8', 'X');
                    else
                        sb.Replace('8', 'O');
                    break;
                case 9:
                    if (player is IOpponent)
                        sb.Replace('9', 'X');
                    else
                        sb.Replace('9', 'O');
                    break;
            }
            
        }
    }
}
