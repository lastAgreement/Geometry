using System;

namespace Geometry
{
    public class Triangle: IHavingArea
    {
        public double[] EdgeLength { get; private set; }
        public bool IsRectangular { get; private set; }

        private double _area;
        public double Area 
        {
            get => _area;
        }

        public Triangle(double edgeLength1, double edgeLength2, double edgeLength3)
        {
            if (edgeLength1 <=0 || edgeLength2 <= 0 || edgeLength3 <= 0)
                throw new ArgumentException("Допустимы только положительные значения.");
            if (!(edgeLength1 + edgeLength2 >= edgeLength3
                && edgeLength2 + edgeLength3 >= edgeLength1 
                && edgeLength3 + edgeLength1 >= edgeLength2))
                throw new ArgumentException("Треугольника с такими длинами сторон не существует.");
            EdgeLength = new double[] { edgeLength1, edgeLength2, edgeLength3 };

            InitIsRectangular();
            InitArea();
        }

        private void InitIsRectangular()
        {
            double[] EdgeLength = new double[this.EdgeLength.Length];
            Array.Copy(this.EdgeLength, EdgeLength, this.EdgeLength.Length);
            Array.Sort(EdgeLength);
            IsRectangular = Math.Pow(EdgeLength[2], 2) == Math.Pow(EdgeLength[0], 2) + Math.Pow(EdgeLength[1],2);
        }
        private void InitArea()
        {
            double SemiPerimeter = 0.5 * (EdgeLength[0] + EdgeLength[1] + EdgeLength[2]);
            _area = Math.Sqrt(SemiPerimeter * (SemiPerimeter - EdgeLength[0]) * (SemiPerimeter - EdgeLength[1]) * (SemiPerimeter - EdgeLength[2]));
        }
    }

}
