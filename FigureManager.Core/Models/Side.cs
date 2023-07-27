using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureManager.Core.Models
{
    public class Side
    {
        public Side(double length)
        {
            Length = length;
        }

        public double Length { get; }
    }
}
