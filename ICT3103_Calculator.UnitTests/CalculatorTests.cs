using NUnit.Framework;
using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }


        [Test]
        [TestCase(10, 20)]
        [TestCase(10, 10)]
        [TestCase(10, -10)]
        [TestCase(-10, -10)]
        [TestCase(100000, 10)]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(0, -10)]
        [TestCase(-0, 10)]
        [TestCase(-0, -10)]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum(double a, double b)
        {
            // Act
            double result = _calculator.Add(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(a + b));
        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(10, 10)]
        [TestCase(10, -10)]
        [TestCase(-10, -10)]
        [TestCase(100000, 10)]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(0, -10)]
        [TestCase(-0, 10)]
        [TestCase(-0, -10)]
        public void Subtract_WhenSubbingTwoNumbers_ResultEqualToSub(double a, double b)
        {
            // Act
            double result = _calculator.Subtract(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(a - b));
        }

        [Test]
        [TestCase(10, 20)]
        [TestCase(10, 10)]
        [TestCase(10, -10)]
        [TestCase(-10, -10)]
        [TestCase(100000, 10)]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(0, -10)]
        [TestCase(-0, 10)]
        [TestCase(-0, -10)]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMul(double a, double b)
        {
            // Act
            double result = _calculator.Multiply(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(a * b));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(0, -10)]
        [TestCase(-0, 10)]
        [TestCase(-0, -10)]
        public void Multiply_MultiplyByZero_ResultEqualToZero(double a, double b)
        {
            // Act
            double result = _calculator.Multiply(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(10, 0)]
        public void divideByZero_ResultError(int a, int b)
        {
            // Act
            double result = _calculator.Divide(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(1,2, 0.5)]
        public void Divide_ResultError(int a, int b, double c)
        {
            // Act
            double result = _calculator.Divide(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(c));
        }

        [Test]
        public void FactorialZero_ResultOne()
        {
            // Act
            double result = _calculator.Factorial(0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void FactorialOne_ResultOne()
        {
            // Act
            double result = _calculator.Factorial(1);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(4, 24)]
        [TestCase(5, 120)]
        [TestCase(6, 720)]
        public void Factorial_EqualsFactorial(int a, int b)
        {
            // Act
            double result = _calculator.Factorial(a);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }
    }
}