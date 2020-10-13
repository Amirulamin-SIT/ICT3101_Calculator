using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                if (num1 == 0 && num2 == 0)
                    return 666;
                else
                    return Int32.Parse(num1.ToString() + num2.ToString());
            }
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            return (num1 / num2);
        }
        public double Factorial(double num1)
        {
            if (num1 == 0)
                return 1;
            else
            {
                int res = 1;
                for (int i = 1; i < num1 + 1; i++)
                {
                    res *= i;
                }
                return res;
            }

        }
    }
}
