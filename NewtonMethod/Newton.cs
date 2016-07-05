using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    public static class Newton
    {
        public static double Calculation(int number, int n, double accuracy = 0.0001)
        {
            double a = (double)number / 2, b = (double)1 / n * ((n - 1) * a + (double)(number / Math.Pow(a, (n - 1))));
            while (Math.Abs(a - b) > accuracy)
            {
                a = b;
                b = (double)1 / n * ((n - 1) * a + (double)(number / Math.Pow(a, (n - 1))));
            }
            return b;
        }

        public static double Root(int number, int n, double accuracy = 0.0001)
        {
            if (n <= 0 || accuracy <= 0 || accuracy >= 1)
                throw new ArgumentException("Incorrect data");
            if (number <= 0 && n%2 == 1)
            {
                double result = Calculation(number, n, accuracy);
                return -result;
            }
            return Calculation(number, n, accuracy);
        }

    }
}
