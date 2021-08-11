using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;

namespace GeometryUnitTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Допустимы только положительные значения.")]
        public void Exeption_NegativeRadius()
        {
            Circle circle = new Circle(-3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Допустимы только положительные значения.")]
        public void Exeption_ZeroRadius()
        {
            Circle circle = new Circle(0);
        }

        [TestMethod]
        public void GetArea()
        {
            Circle circle = new Circle(3);
            Assert.AreEqual(circle.Area, 28.274333882308138);
        }
    }
}
