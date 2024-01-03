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
    }
}
