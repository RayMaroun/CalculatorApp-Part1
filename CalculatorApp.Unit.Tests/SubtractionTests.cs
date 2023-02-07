using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    public class SubtractionTests
    {
        [Fact]
        public void Subtract_SubtractingTwoNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            var calculator = new Calculator();
            var firstNumber = 5;
            var secondNumber = 3;
            var expectedResult = 2;

            // Act
            var result = calculator.Subtract(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
