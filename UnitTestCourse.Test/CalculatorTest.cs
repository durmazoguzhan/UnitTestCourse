using UnitTestCourse.App;
using Xunit;

namespace UnitTestCourse.Test
{
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTest()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = 3;

            // Act
            int total = _calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(8, total);
        }

        [Theory]
        [InlineData(1, 5, -4)]
        [InlineData(9, 8, 1)]
        [InlineData(3, 3, 0)]
        public void SubtractTest(int firstNumber, int secondNumber, int expectedTotal)
        {
            int actualTotal = _calculator.Subtract(firstNumber, secondNumber);
            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(5, 10, 0.5)]
        public void Divide_SimpleValues_ReturnTotal(double firstNumber, double secondNumber, double expectedTotal)
        {
            double actualTotal = _calculator.Divide(firstNumber, secondNumber);
            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(15, 0, 0)]
        [InlineData(0, 5, 0)]
        public void Divide_ZeroValues_ReturnZero(double firstNumber, double secondNumber, double expectedTotal)
        {
            double actualTotal = _calculator.Divide(firstNumber, secondNumber);
            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
