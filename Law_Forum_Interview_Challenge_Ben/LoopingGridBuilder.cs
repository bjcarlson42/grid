using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben
{
    public class LoopingGridBuilder : IGridBuilder
    {
        readonly Random random = new Random();

        public Grid CreateGrid(int rows, int div, int lower, int upper)
        {
            var grid = new Grid();
          
            do
            {
                grid.Rows.Clear();
                for(int i = 0; i < rows; i++)
                {
                    grid.Rows.Add(CreateRow(div, lower, upper));
                }
            }
            while (grid.Totals.Column1 % div == 0 ||
            grid.Totals.Column2 % div == 0 ||
            grid.Totals.Column3 % div == 0 ||
            grid.Totals.Total % div == 0);

            return grid;
        }

        Row CreateRow(int div, int lower, int upper)
        {
            var row = new Row
            {
                Column1 = GetNumber(div, lower, upper),
                Column2 = GetNumber(div, lower, upper)      
            };
            do
            {
                row.Column3 = GetNumber(div, lower, upper);
            }
            while (row.Total % div == 0);

            return row;
        }

        public int GetNumber(int div, int lower, int upper)
        {
            int num;

            do
            {
                num = random.Next(lower, upper);
            }
            while (num % div == 0);

            return num;

        }
    }
}
