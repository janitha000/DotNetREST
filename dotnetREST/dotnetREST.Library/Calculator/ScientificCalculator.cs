using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.Calculator
{
    public class ScientificCalculator : ICalculator
    {
        public double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        public double Div(double value1, double value2)
        {
            return value1 / value2;

        }

        public bool IsPrime(int value)
        {
            if (value == 1) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(value));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (value % i == 0) return false;
            }
            return true;
        }

        public double Mul(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Sub(double value1, double value2)
        {
            return value1 - value2;

        }
    }
}
