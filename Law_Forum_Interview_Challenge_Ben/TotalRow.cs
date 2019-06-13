using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public class TotalRow : IRow
    {
        private readonly IGrid _grid;

        public TotalRow(IGrid grid)
        {
            _grid = grid;
        }

        public int Column1 => _grid.Rows.Sum(row => row.Column1);
        public int Column2 => _grid.Rows.Sum(row => row.Column2);
        public int Column3 => _grid.Rows.Sum(row => row.Column3);
        public int Total => _grid.Rows.Sum(row => row.Total);
    }
}
