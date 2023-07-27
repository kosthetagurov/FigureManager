using FigureManager.Core.Models;

namespace FigureManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var circle = new Circle(22.12);
            Console.WriteLine($"Круг с радиусом {circle.Radius} имеет площадь {circle.Area()} и длину {circle.Length()}");

            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Треугольник со сторонами {triangle.ToString()} имеет площадь {triangle.Area()} и периметр {triangle.Perimeter()}");
            triangle.IsRightAngledTriangle();

            Console.ReadKey();
        }
    }
}