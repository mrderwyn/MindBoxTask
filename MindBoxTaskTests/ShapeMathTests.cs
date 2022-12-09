namespace MindBoxTaskTests
{
    [TestFixture]
    public class ShapeMathTests
    {
        private readonly double precision = 0.001;

        [Test]
        public void GetAreaTest_ObjectIsNull_ThrowNullArgumentException() =>
            Assert.Throws<ArgumentNullException>(() => ShapeMath.GetArea(null!));

        [Test]
        [TestCaseSource(typeof(ShapeMathTestCaseSource), nameof(ShapeMathTestCaseSource.NonShapeObjectsContainMethod))]
        public void GetAreaTest_NonShapeObjectContainMethod_ReturnValidResult(object shape, double expected)
        {
            Assert.That(ShapeMath.GetArea(shape), Is.EqualTo(expected).Within(this.precision));
        }

        [Test]
        [TestCaseSource(typeof(ShapeMathTestCaseSource), nameof(ShapeMathTestCaseSource.ShapeObjects))]
        public void GetAreaTest_ShapeObject_ReturnValidResult(object shape, double expected)
        {
            Assert.That(ShapeMath.GetArea(shape), Is.EqualTo(expected).Within(this.precision));
        }

        [Test]
        [TestCaseSource(typeof(ShapeMathTestCaseSource), nameof(ShapeMathTestCaseSource.NonShapeObjectsWithoutMethod))]
        public void GetAreaTest_NonShapeObjectWithoutMethod_ThrowArgumentException(object shape) =>
            Assert.Throws<ArgumentException>(() => ShapeMath.GetArea(shape));
    }
}