using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Law_Forum_Interview_Challenge_Ben.Models
{
    public class GridViewModel
    {
        public Grid Grid { get; set; }
        public GridBuilderType BuilderType { get; set; }

        [Range(1,int.MaxValue)]
        [Required]
        public int NumRows { get; set; }

        [Range(1, int.MaxValue)]
        [Required]
        public int NumDivisibleBy { get; set; }

        [Range(1, int.MaxValue)]
        [Required]
        public int NumLower { get; set; }

        [Range(1, int.MaxValue)]
        [Required]
        public int NumUpper { get; set; }

        public enum GridBuilderType
        {
            Looping
        }
    }
}
