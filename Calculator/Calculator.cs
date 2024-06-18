using System;

namespace Calculator
{
    public class Calculator // Would it make sense to have a class called Operations and determine the four operations there?
    {
        public decimal Sum(decimal firstValue, decimal secondValue)
        {
            return firstValue + secondValue;
        }

        public decimal Sub(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }

        public decimal Division(decimal firstValue, decimal secondValue)
        {
            if (secondValue == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            decimal result = firstValue / secondValue;
            return Math.Round(result, 2);
        }

        public decimal Multiplication(decimal firstValue, decimal secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
