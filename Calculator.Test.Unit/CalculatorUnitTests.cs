using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNunmbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(4, 2, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(11, 5, 2.2)]
        [TestCase(9, 0.5, 18)]
        [TestCase(0, 2, 0)]
        [TestCase(2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Divide_ResultIsCorrect(double divisor, double dividend, double result)
        {
            Assert.That(_uut.Divide(divisor, dividend), Is.EqualTo(result));
        }

        [Test]
        public void Accumulator_Clear_Empty()
        {
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }

        [TestCase(4, 2, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, 2, -2)]
        public void Accumulator_Arithemtic_Test(double a, double b, double result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
    }
}
