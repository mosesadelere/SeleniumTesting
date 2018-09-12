using System;
using System.Collections.Generic;
using System.Text;

namespace Starting
{
    public class BasicMaths
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Substract(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num1 == 0)
            {
                throw new DivideByZeroException("Number 1 can not be zero: {0}" + num1);
            }
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
