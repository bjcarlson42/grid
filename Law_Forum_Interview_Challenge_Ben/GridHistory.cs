using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public class GridHistory
    {

        public int gridNumber = 1;
        public string Lgb;
        public int NumRows;
        public int NotDivisibleBy;
        public int Lower;
        public int Upper;

        public GridHistory(string l, int r, int d, int lo, int u)
        {
            Lgb = l;
            NumRows = r;
            NotDivisibleBy = d;
            Lower = lo;
            Upper = u;
        }
    }
}
