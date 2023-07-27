using FigureManager.Core.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureManager.Core.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void InvariantTest()
        {
            try
            {
                var circle = new Circle(-5);
            }
            catch (Exception exc)
            {
                Assert.IsTrue(exc.GetType() == typeof(ArgumentException));
            }            
        }

        [TestMethod]
        public void AreaTest()
        {
            var circle = new Circle(5);

            var area = circle.Area();

            Assert.AreEqual(Math.Round(area), 79);
        }

        [TestMethod]
        public void LengthTest()
        {
            var circle = new Circle(5);

            var length = circle.Length();

            Assert.AreEqual(Math.Round(length), 31);
        }
    }
}
