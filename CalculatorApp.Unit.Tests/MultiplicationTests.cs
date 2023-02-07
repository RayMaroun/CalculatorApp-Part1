using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    public class MultiplicationTests
    {
        [Fact]
        public void Multiply_MultiplyingTwoNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            var calculator = new Calculator();
            var firstNumber = 3;
            var secondNumber = 4;
            var expectedResult = 12;

            // Act
            var result = calculator.Multiply(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
