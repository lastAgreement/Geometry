using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;

namespace GeometryUnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Допустимы только положительные значения.")]
        public void Exeption_ZeroEdgeLength()
        {
            Triangle triangle = new Triangle(0, 6, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Допустимы только положительные значения.")]
        public void Exeption_NegativeEdgeLength()
        {
            Triangle triangle = new Triangle(3, -6, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Треугольника с такими длинами сторон не существует.")]
        public void Exeption_TriangleNotExists()
        {
            Triangle triangle = new Triangle(3, 3, 20);
        }

        [TestMethod]
        public void IsRectangular_NotRectangular()
        {
            Triangle triangle = new Triangle(3, 6, 4);
            Assert.AreEqual(triangle.IsRectangular, false);
        }

        [TestMethod]
        public void IsRectangular_Rectangular()
        {
            Triangle triangle = new Triangle(3, 5, 4);
            Assert.AreEqual(triangle.IsRectangular, true);
        }

        [TestMethod]
        public void GetArea()
        {
            Triangle triangle = new Triangle(3, 5, 4);
            Assert.AreEqual(triangle.Area, 6);
        }
    }
}
