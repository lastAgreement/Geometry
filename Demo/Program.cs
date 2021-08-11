using System;
using Geometry;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IHavingArea figure = new Circle(8.5);
            Console.WriteLine(figure.GetType() + " area = " + figure.Area.ToString());

            Triangle triangle = new Triangle(3, 5, 4);
            Console.WriteLine("Triangle area = " + triangle.Area.ToString());
            Console.WriteLine("Triangle IsRectangular? " + triangle.IsRectangular.ToString());
        }
    }
}
