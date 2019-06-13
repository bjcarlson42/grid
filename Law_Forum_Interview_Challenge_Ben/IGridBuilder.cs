using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    interface IGridBuilder
    {
        Grid CreateGrid(int rows, int divisor, int lower, int upper);
    }
}
