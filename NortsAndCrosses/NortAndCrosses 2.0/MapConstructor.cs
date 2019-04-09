using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortAndCrosses_2._0
{
    public class MapConstructor
    {
        private StringBuilder sb;

        public MapConstructor()
        {
            sb = new StringBuilder();
        }

        public void Draw(List<int> map)
        {
            sb.Append('-', 20).Append('_', 20)
                .Append('-', 20).Append('_', 20)
                .Append('-', 20).Append('_', 20);
        }

        public void Update()
        {
            // figure a way to update existing map with newly removed shit
        }
    }
}
