using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary2
{
    public class Calculator
    {
        int num1, num2, result;

        public int Add(int num1, int num2)
        {
            return result = num1 + num2;

        }
        public int Sub(int num1, int num2)
        {
           return  result = num1 - num2;

        }
        public int Mul(int num1, int num2)
        {
            return result  = num1 * num2;

        }
    }
}
