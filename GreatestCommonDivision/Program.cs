using System;

namespace GreatestCommonDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a program for calculating the greatest common division of two numbers!");
            Console.WriteLine("Please enter two numbers");

            Console.Write("Enter first number: ");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"The greatest common divisor of {firstNumber} and {secondNumber} is " 
                + GreatestCommonDivisor.GetGreatestCommonDivisorByDivision(firstNumber, secondNumber));

            Console.WriteLine($"The greatest common divisor of {firstNumber} and {secondNumber} is "
                + GreatestCommonDivisor.GetGreatestCommonDivisorBySubstraction(firstNumber, secondNumber));

            Console.WriteLine($"The greatest common divisor of {firstNumber} and {secondNumber} is "
                + GreatestCommonDivisor.GetGreatestCommonDivisorByRecursion(firstNumber, secondNumber));

            Console.WriteLine($"The greatest common divisor of {firstNumber} and {secondNumber} is "
                + GreatestCommonDivisor.GetGreatestCommonDivisorByRecursionTernaryOperator(firstNumber, secondNumber));
        }
    }
}
