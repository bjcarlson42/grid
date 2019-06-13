using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public interface IRow
    {
        int Column1 { get; }
        int Column2 { get; }
        int Column3 { get; }
        int Total { get; }
    }
}
