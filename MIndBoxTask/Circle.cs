using System;

namespace MIndBoxTask
{
    public class Circle : Shape
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("radius cannot be less than 0", nameof(radius));
            }

            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
