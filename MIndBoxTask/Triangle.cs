using System;

namespace MIndBoxTask
{
    public class Triangle : Shape
    {
        public readonly double A, B, C;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("side cannot be 0 or less.");
            }

            if (!IsExist())
            {
                throw new ArgumentException("unexisted triangle (one side is greater than the sum of the other two sides)");
            }

            (this.A, this.B, this.C) = (a, b, c);

            bool IsExist()
            {
                var maxSide = Math.Max(a, Math.Max(b, c));
                return maxSide < (a + b + c - maxSide);
            }
        }

        public override double GetArea()
        {
            double p = (this.A + this.B + this.C) / 2;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public bool IsRectangled(double precision = 0.0000001)
        {
            double aSqr = this.A * this.A;
            double bSqr = this.B * this.B;
            double cSqr = this.C * this.C;
            if (aSqr > bSqr)
            {
                return aSqr > cSqr ? CheckSqrs(bSqr, cSqr, aSqr) : CheckSqrs(aSqr, bSqr, cSqr);
            }

            return bSqr > cSqr ? CheckSqrs(aSqr, cSqr, bSqr) : CheckSqrs(aSqr, bSqr, cSqr);

            bool CheckSqrs(double a, double b, double hypotenuse)
            {
                return Math.Abs(hypotenuse - a - b) <= precision;
            }
        }
    }
}
