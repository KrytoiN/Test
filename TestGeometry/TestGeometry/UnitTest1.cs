using Geometry;

namespace TestGeometry
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleDefault()
        {
            Circle circle = new Circle();
            Assert.AreEqual(0, circle.Square());
        }

        [TestMethod]
        public void CircleValues()
        {
            double r = 3;
            Circle circle = new Circle(r);
            double expectedSquare = Math.PI * Math.Pow(r, 2);
            Assert.AreEqual(expectedSquare, circle.Square());
        }

        [TestMethod]
        public void TriangleDefault()
        {
            Triangle triagnle = new Triangle();
            Assert.AreEqual(0, triagnle.Square());
        }

        [TestMethod]
        public void TriangleValues()
        {
            double A = 3;
            double B = 2;
            double C = 1;
            Triangle triagnle = new Triangle(A, B, C);
            double p = (A + B + C) / 2;
            double expectedSquare = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Assert.AreEqual(expectedSquare, triagnle.Square());
        }

        [TestMethod]
        public void isRightTriagle()
        {
            double A = 3;
            double B = 4;
            double C = 5;
            Triangle triagnle = new Triangle(A, B, C);
            Assert.IsTrue(triagnle.isRectangular());
        }

    }
}