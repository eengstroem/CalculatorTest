using System;

namespace Calculator
{
    //cheeky test
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double Multiply(double a, double b)
        {
            return Accumulator = a* b;
        }

        public double Power(double a, double b)
        {
            return Accumulator = Math.Pow(a, b);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor != 0)
            {
                return Accumulator = dividend / divisor;
            }
            else
            {
                Console.WriteLine("You cannot divide by 0");
                return Accumulator = 0; 
            }

        }

        public double Accumulator
        {
            get;
            private set;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
