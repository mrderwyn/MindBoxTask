namespace MindBoxTaskTests
{
    [TestFixture]
    public class TriangleTests
    {
        private readonly double precision = 0.001;

        [TestCase(0, 2, 2.5)]
        [TestCase(2, 0, 2.5)]
        [TestCase(4, 2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-3, 2, 2.5)]
        [TestCase(-4, -6, -0.00001)]
        public void CtorTest_SidesAreZeroOrNegative_ThrowArgumentException(double a, double b, double c) =>
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));

        [TestCase(1, 2, 3)]
        [TestCase(5, 6, 12)]
        [TestCase(1, 2, 3.00001)]
        public void CtorTest_UnexistedTriangle_ThrowArgumentException(double a, double b, double c) =>
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));

        [TestCase(1, 2, 2.5)]
        public void CtorTest_ValidSides(double a, double b, double c)
        {
            var shape = new Triangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(shape.A, Is.EqualTo(a));
                Assert.That(shape.B, Is.EqualTo(b));
                Assert.That(shape.C, Is.EqualTo(c));
            });
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(2, 2, 3, 1.9843)]
        public void GetAreaTest(double a, double b, double c, double expected)
        {
            var shape = new Triangle(a, b, c);
            Assert.That(shape.GetArea(), Is.EqualTo(expected).Within(this.precision));
        }

        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(2, 2, 3, ExpectedResult = false)]
        [TestCase(3, 4, 5.001, ExpectedResult = false)]
        public bool IsRectangledTest_WithDefaultPrecision(double a, double b, double c) =>
            (new Triangle(a, b, c)).IsRectangled();

        [TestCase(3, 4, 5, 0.1, ExpectedResult = true)]
        [TestCase(2, 2, 3, 0.1, ExpectedResult = false)]
        [TestCase(3, 4, 5.001, 0.1, ExpectedResult = true)]
        public bool IsRectangledTest_WithCustomPrecision(double a, double b, double c, double customPrecision) =>
            (new Triangle(a, b, c)).IsRectangled(customPrecision);
    }
}
