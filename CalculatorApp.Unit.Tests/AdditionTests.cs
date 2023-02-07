using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Unit.Tests
{
    public class AdditionTests
    {
        [Fact]
        public void Add_AddingTwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            var firstNumber = 3;
            var secondNumber = 4;
            var expectedResult = 7;

            // Act
            var result = calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
