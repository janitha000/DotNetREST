using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetREST.Library.Calculator
{
    public interface ICalculator
    {
        double Add(double value1, double value2);
        double Sub(double value1, double value2);
        double Mul(double value1, double value2);
        double Div(double value1, double value2);

        bool IsPrime(int value);
    }
}
