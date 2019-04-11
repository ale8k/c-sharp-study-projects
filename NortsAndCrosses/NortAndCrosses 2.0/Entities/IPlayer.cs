using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0.Entities
{
    public interface IPlayer
    {
        string Title { get; set; }
        int Input { get; set; }
        List<int> Map { get; set; }
    }
}
