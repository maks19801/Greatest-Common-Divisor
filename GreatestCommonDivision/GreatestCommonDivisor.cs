using System;
using System.Collections.Generic;
using System.Text;

namespace GreatestCommonDivision
{
    class GreatestCommonDivisor
    {
        public static int GetGreatestCommonDivisorByDivision(int firstNumber, int secondNumber)
        {
            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber % secondNumber;
                }
                else
                {
                    secondNumber = secondNumber % firstNumber;
                }
            }
            return firstNumber + secondNumber;
        }
        public static int GetGreatestCommonDivisorBySubstraction(int firstNumber, int secondNumber)
        {
            while (firstNumber != 0 && secondNumber != 0)
            {
                if (firstNumber > secondNumber)
                {
                    firstNumber = firstNumber - secondNumber;
                }
                else
                {
                    secondNumber = secondNumber - firstNumber;
                }
            }
            return firstNumber + secondNumber;
        }
        public static int GetGreatestCommonDivisorByRecursion(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                return secondNumber;
            }
            else
            {
                return GetGreatestCommonDivisorByRecursion(secondNumber % firstNumber, firstNumber);
            }
        }

        internal static int GetGreatestCommonDivisorByRecursionTernaryOperator(int firstNumber, int secondNumber)
        {
            return firstNumber != 0 ? GetGreatestCommonDivisorByRecursionTernaryOperator(secondNumber % firstNumber, firstNumber) : secondNumber;
        }
    }
}
