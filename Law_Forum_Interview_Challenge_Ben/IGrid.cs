using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public interface IGrid
    {
        IRow Totals { get; }
        IEnumerable<IRow> Rows { get; }
    }
}
