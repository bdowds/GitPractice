using System;
using System.Collections.Generic;
using System.Text;

namespace GitPractice
{
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            int product = 0;
            product = num1 * num2;
            return product;
        }

        public int Divide(int num1, int num2)
        {
            int quotient = 0;
            quotient = num1 / num2;
            return quotient;
        }
    }
}
