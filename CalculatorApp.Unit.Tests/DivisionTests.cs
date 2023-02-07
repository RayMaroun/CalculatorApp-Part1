using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    public class DivisionTests
    {
        [Fact]
        public void Divide_DividingTwoNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            var calculator = new Calculator();
            var numerator = 6;
            var denominator = 2;
            var expectedResult = 3;

            // Act
            var result = calculator.Divide(numerator, denominator);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
