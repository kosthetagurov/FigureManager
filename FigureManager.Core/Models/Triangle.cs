using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureManager.Core.Models
{
    public class Triangle : FigureBase, IFigure
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            Sides.Add(new Side(sideA));
            Sides.Add(new Side(sideB));
            Sides.Add(new Side(sideC));

            if (Sides.Any(x => x.Length <= 0))
            {
                throw new ArgumentException("Сторона фигуры не может быть меньше или равна 0");
            }
        }

        public double Area()
        {
            double semiPerimeter = Sides.Sum(x => x.Length) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - Sides[0].Length) * (semiPerimeter - Sides[1].Length) * (semiPerimeter - Sides[2].Length));
            return area;
        }

        public override double Perimeter()
        {
            return Sides.Sum(x => x.Length);
        }

        public bool IsRightAngledTriangle()
        {
            // Находим наибольшую сторону (гипотенузу)
            double hypotenuse = Sides.Max(x => x.Length);

            double SideA = Sides[0].Length;
            double SideB = Sides[1].Length;
            double SideC = Sides[2].Length;

            // Проверяем, соответствует ли теореме Пифагора
            if (hypotenuse == SideA)
                return SideA * SideA == SideB * SideB + SideC * SideC;
            else if (hypotenuse == SideB)
                return SideB * SideB == SideA * SideA + SideC * SideC;
            else
                return SideC * SideC == SideA * SideA + SideB * SideB;
        }
    }
}
