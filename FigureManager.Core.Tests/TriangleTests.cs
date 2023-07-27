using FigureManager.Core.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureManager.Core.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void InvariantTest()
        {
            try
            {
                var triangle = new Triangle(0, -1, 5);
            }
            catch (Exception exc)
            {
                Assert.IsTrue(exc.GetType() == typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void AreaTest()
        {
            var triangle = new Triangle(10, 11, 15);

            var area = triangle.Area();

            Assert.AreEqual(Math.Round(area), 55);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            var triangle = new Triangle(10, 11, 15);

            var P = triangle.Perimeter();

            Assert.AreEqual(Math.Round(P), 10 + 11 + 15);
        }

        [TestMethod]
        public void IsRightAngledTriangleTest_Positive()
        {
            var triangle = new Triangle(3, 4, 5);

            var triangle_test = triangle.IsRightAngledTriangle();

            Assert.IsTrue(triangle_test);
        }

        [TestMethod]
        public void IsRightAngledTriangle_Negative()
        {
            var triangle = new Triangle(10, 5, 6);

            var triangle_test = triangle.IsRightAngledTriangle();

            Assert.IsFalse(triangle_test);
        }
    }
}
