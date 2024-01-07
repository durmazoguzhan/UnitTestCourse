namespace UnitTestCourse.App
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
                return 0;
            else
                return firstNumber / secondNumber;
        }
    }
}
