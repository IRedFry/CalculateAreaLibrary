namespace CalcAreaTests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void RadiusIsLessThanZeroTest()
        {

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Circle c = new Circle(-4);
            });
        }

        [TestMethod]
        public void OneSideIsLessThanSumOfOthersTest()
        {


            Assert.ThrowsException<Exception>(() =>
            {
                Triangle t = new Triangle(2, 2, 5);
            }, "One of sides is bigger then sum of others");
        }

        [TestMethod]
        public void CircleWithRadius5Test()
        {
            Circle c = new Circle(5);
            double area = c.GetArea();
            double result = Math.PI * Math.Pow(5, 2);

            Assert.AreEqual(result, area);
        }

        [TestMethod]
        public void TriangleWithSides5_8_12Test()
        {
            Triangle t = new Triangle(5, 8, 12);
            double p = (5 + 8 + 12) / 2.0;
            double result = Math.Sqrt(p * (p - 5) * (p - 8) * (p - 12));
            double area = t.GetArea();

            Assert.AreEqual(result, area);
        }

        [TestMethod]
        public void RightTriangleWithSides3_4_5Test()
        {
            Triangle t = new Triangle(3, 4, 5);
            double result = 3 * 4 / 2;

            double area = t.GetArea();

            Assert.AreEqual(result, area);
        }
    }
}