using System;

namespace Geometry
{
    public class Circle : IHavingArea
    {
        public double Radius { get; private set; }

        private double _area;
        public double Area
        {
            get => _area;
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Допустимы только положительные значения.");
            Radius = radius;

            InitArea();
        }

        private void InitArea()
        {
            _area = Math.PI * Radius * Radius;
        }
    }

}
