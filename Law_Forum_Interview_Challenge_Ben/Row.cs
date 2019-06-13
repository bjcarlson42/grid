using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public class Row : IRow
    {
        public int Column1 { get; set; }
        public int Column2 { get; set; }
        public int Column3 { get; set; }
        public int Total => Column1 + Column2 + Column3;
    }
}
