namespace MindBoxTaskTests
{
    [TestFixture]
    public class CircleTests
    {
        private readonly double precision = 0.001;

        [TestCase(-1)]
        [TestCase(-0.00001)]
        public void CtorTest_RadiusLessThanZero_ThrowArgumentException(double r) =>
            Assert.Throws<ArgumentException>(() => new Circle(r));

        [TestCase(0)]
        [TestCase(2)]
        public void CtorTest_ValidRadius(double r)
        {
            var shape = new Circle(r);
            Assert.That(shape.Radius, Is.EqualTo(r));
        }

        [TestCase(0, 0)]
        [TestCase(2, 12.566)]
        public void GetAreaTest(double r, double expectedArea)
        {
            var shape = new Circle(r);
            Assert.That(shape.GetArea(), Is.EqualTo(expectedArea).Within(this.precision));
        }
    }
}
