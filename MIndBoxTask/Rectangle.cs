namespace MIndBoxTask
{
    public class Rectangle
    {
        public readonly double A, B;

        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("side cannot be 0 or less.");
            }

            (this.A, this.B) = (a, b);
        }

        public double GetArea()
        {
            return this.A * this.B;
        }
    }
}
