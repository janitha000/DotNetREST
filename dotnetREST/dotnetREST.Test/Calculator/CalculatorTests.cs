using dotnetREST.Library.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace dotnetREST.Test.Calculator
{
    public class CalculatorTests
    {
        private ScientificCalculator _calculator;
        private double _value1;
        private double _value2;

        public CalculatorTests()
        {
            _calculator = new ScientificCalculator();
            _value1 = 10;
            _value2 = 2;
        }
        [Fact]
        public void AddTest()
        {
            double result = _calculator.Add(_value1, _value2);
            Assert.Equal(result, 12.0);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void IsPrimeSuccess(int value)
        {
            bool result = _calculator.IsPrime(value);

            Assert.True(result, $"{value} should be a prime");
        }

        [Theory]
        [InlineData(8)]
        [InlineData(14)]
        [InlineData(16)]
        public void IsPrimeFail(int value)
        {
            bool result = _calculator.IsPrime(value);

            Assert.False(result, $"{value} should not be a prime");
        }
    }
}
