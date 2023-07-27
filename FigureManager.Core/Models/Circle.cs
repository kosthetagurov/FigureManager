using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureManager.Core.Models
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус не может быть меньше или равен 0");
            }

            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Length()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
