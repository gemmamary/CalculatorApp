using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static System.Console;
using static Calculator.Calculation;

namespace Calculator
{
    public class Operations
    {
        public static double GetFirstNumber()
        { 
            WriteLine($"{Environment.NewLine}Type in the first number and press Enter: ");
            var first = ReadLine();

            if(double.TryParse(first, out double value))
            {
                return value;
            }
            else
            {
                return GetFirstNumber();
            }
        }

        public static double GetSecondNumber()
        {
            WriteLine($"{Environment.NewLine}Type in the the second number and press Enter: ");
            var second = ReadLine();

            if (double.TryParse(second, out double value))
            {
                return value;
            }
            else
            {
                return GetSecondNumber();
            }
        }

        public static double CalculateSumOfNumbers(double firstNumber, double secondNumber)
        {
            var calculationChoices = new Dictionary<char, string>()
            {
                { 'A', "Addition" },
                { 'B', "Subtraction" },
                { 'C', "Multiplication" },
                { 'D', "Division" }
            };

            double sum = 0;
            bool isFinished = false;

            while(!isFinished)
            {
                WriteLine($"{Environment.NewLine}Choose a calculation type from the list below: ");

                foreach (KeyValuePair<char, string> choice in calculationChoices.OrderBy(val => val.Key))
                    WriteLine($"{choice.Key} for {choice.Value}");

                var calculationChoice = Char.ToUpper(ReadKey().KeyChar);

                if (calculationChoices.ContainsKey(calculationChoice))
                {
                    sum = calculationChoice switch
                    {
                        'A' => AddNumbers(firstNumber, secondNumber),
                        'B' => SubtractNumbers(firstNumber, secondNumber),
                        'C' => MultiplyNumbers(firstNumber, secondNumber),
                        'D' => DivideNumbers(firstNumber, secondNumber),
                        _ => throw new ArgumentException($"Invalid {nameof(calculationChoice)}"),
                    };

                    isFinished = true;
                } else
                {
                    WriteLine($"{Environment.NewLine}{calculationChoice} is an invalid selection. Please try again. ");
                }
            }
            return sum;
        }
    }
}
