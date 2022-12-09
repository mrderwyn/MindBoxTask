using MIndBoxTask;

namespace MindBoxTaskTests
{
    public sealed class ShapeMathTestCaseSource
    {
        public static IEnumerable<TestCaseData> NonShapeObjectsContainMethod
        {
            get
            {
                yield return new TestCaseData(new Rectangle(2, 4), 8);
                yield return new TestCaseData(new Rectangle(1, 4), 4);
                yield return new TestCaseData(new Rectangle(2.5, 3.7), 9.25);
                yield return new TestCaseData(new Rectangle(0.002, 0.004), 0.000008);
            }
        }

        public static IEnumerable<TestCaseData> NonShapeObjectsWithoutMethod
        {
            get
            {
                yield return new TestCaseData("123");
                yield return new TestCaseData(25);
                yield return new TestCaseData(true);
                yield return new TestCaseData(new object());
            }
        }

        public static IEnumerable<TestCaseData> ShapeObjects
        {
            get
            {
                yield return new TestCaseData(new Circle(2), 12.566);
                yield return new TestCaseData(new Triangle(3, 4, 5), 6);
                yield return new TestCaseData(new Triangle(2, 2, 3), 1.9843);
            }
        }
    }
}
