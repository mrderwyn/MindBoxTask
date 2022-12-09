using System;
using System.Reflection;

namespace MIndBoxTask
{
    public static class ShapeMath
    {
        public static double GetArea(object shape)
        {
            if (shape is null)
            {
                throw new ArgumentNullException(nameof(shape));
            }

            if (shape is Shape s)
            {
                return s.GetArea();
            }

            var method = shape.GetType().GetMethod("GetArea", Type.EmptyTypes);
            if (method is not null && method.ReturnType == typeof(double))
            {
                var result = method.Invoke(shape, null);
                if (result is not null)
                {
                    return (double)result;
                }
            }

            throw new ArgumentException("the object does not containt method GetArea or this method returns null value", nameof(shape));
        }
    }
}
