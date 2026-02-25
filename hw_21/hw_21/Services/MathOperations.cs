using System.Numerics;

namespace hw_21.Services
{
    public class MathOperations<T> where T : INumber<T>
    {
        public T Add(T a, T b) => a + b;

        public T Subtract(T a, T b) => a - b;

        public T Multiply(T a, T b) => a * b;

        public T Divide(T a, T b)
        {
            if (b == T.Zero)
                throw new ArgumentException("Nu poți împărți la zero.");

            return a / b;
        }
    }
}
