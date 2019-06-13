using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public class Grid : IGrid
    {
        
        public Grid()
        {
            Totals = new TotalRow(this);   
        }
        
        public ICollection<Row> Rows = new List<Row>();

        public IRow Totals { get; }

        IEnumerable<IRow> IGrid.Rows => Rows;
    }
}
