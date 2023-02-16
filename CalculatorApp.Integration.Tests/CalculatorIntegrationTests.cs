using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorApp.Integration.Tests
{
    public class CalculatorIntegrationTests
    {
        [Fact]
        public void AdditionAndSubtraction_ShouldReturnCorrectResult_WhenNumbersAreProvided()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result1 = calculator.Add(2, 3);
            var result2 = calculator.Subtract(5, 2);

            // Assert
            Assert.Equal(5, result1);
            Assert.Equal(3, result2);
        }

        [Fact]
        public void MultipleOperations_ShouldProduceExpectedResult_WhenValidInputsAreGiven()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result1 = calculator.Add(2, 3);
            var result2 = calculator.Subtract(5, 2);
            var result3 = calculator.Multiply(result1, result2);

            // Assert
            Assert.Equal(5, result1);
            Assert.Equal(3, result2);
            Assert.Equal(15, result3);
        }

        [Fact]
        public void PerformComplexMathematicalOperations_CorrectlyAppliesMultipleOperations_ExpectedResults()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result1 = calculator.Add(2, 3);
            var result2 = calculator.Subtract(5, 2);
            var result3 = calculator.Multiply(result1, result2);
            var result4 = calculator.Divide(result3, 2);

            // Assert
            Assert.Equal(5, result1);
            Assert.Equal(3, result2);
            Assert.Equal(15, result3);
            Assert.Equal(7.5, result4);
        }
    }
}
