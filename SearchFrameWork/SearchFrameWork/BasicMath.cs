using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchFrameWork
{
    public class BasicMath
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num1.Equals(0))
            {
                throw new DivideByZeroException("Number can be zero!!!");
            }

            if (num2.Equals(0))
            {
                throw new StackOverflowException("Other number can not be zero.");
            }
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
