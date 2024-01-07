using UnitTestCourse.App;
using Xunit;

namespace UnitTestCourse.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = 3;
            Calculator calculator = new();

            // Act
            int total = calculator.Add(firstNumber, secondNumber);

            // Assert
            Assert.Equal(8, total);
        }

        [Theory]
        [InlineData(1, 5, -4)]
        [InlineData(9, 8, 1)]
        [InlineData(3, 3, 0)]
        public void SubtractTest(int firstNumber, int secondNumber, int expectedTotal)
        {
            Calculator calculator = new();
            int actualTotal = calculator.Subtract(firstNumber, secondNumber);
            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
