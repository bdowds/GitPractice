using System;
using System.Collections.Generic;
using System.Text;

namespace GitPractice
{
    class Calculator
    {
        public int Add(int num1, int num2)
        {
            int sum = 0;
            sum = num1 + num2;
            return sum;
        }

        public int Subtract(int num1, int num2)
        {
            int difference = 0;
            difference = num1 - num2;
            return difference;
        }

        public int Multiply(int num1, int num2)
        {
            int product = 0;
            product = num1 * num2;
            return product;
        }

        public int Divide(int num1, int num2)
        {
            return 0;
        }
    }
}
