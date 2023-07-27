using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureManager.Core.Models
{
    public abstract class FigureBase : IFigure
    {
        protected List<Side> Sides { get; set; }

        public FigureBase()
        {
            Sides = new List<Side>();
        }

        public abstract double Perimeter();

        public double Area()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Join(", ", Sides.Select(x => x.Length));
        }
    }
}
