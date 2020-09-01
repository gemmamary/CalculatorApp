using System;
using System.Linq;
using static System.Console;
using static Calculator.Calculation;

namespace Calculator
{
    public class Operations
    {
        public static char GetCalculationType()
        {
            var chosenLetter = '\0';

            do
            {
                // C# (and other languages) have a sugar syntax to make it easier to interpolate strings.
                // Add $ before the string so you can use variables inside a string
                // to use the variables, wrap them in a {} inside a string
                // Use Environment.NewLine instead of /n or /r
                // Write line will break a line at the end, there's no need to add another break line.
                WriteLine($"{Environment.NewLine}Choose a calculation type from the list below:");

                string[] lettersForCalculation = { "A for Addition", "B for Subtraction", "C for Multiplication", "D for Division" };

                // There's no need for {} after foreach here
                // Whenever you have a loop/condition that only has one line, you don't need {}.

                foreach (string v in lettersForCalculation)
                    WriteLine(v);

                chosenLetter = Console.ReadKey().KeyChar; // From what i understood, you want A,B,C or D, no need to read line, just read key
                Console.WriteLine(); // Since we're reading key we won't have a break line, an empty Console.WriteLine(); will fix that issue
            } while (new char[] { 'A', 'B', 'C', 'D'}.All(x => x != chosenLetter)); // Will print everything again if user chose an invalid char

            return chosenLetter;
        }

        public static double GetFirstNumber()
        {
            Write("Type in the the first number and press Enter: ");
            var first = ReadLine();

            // Check if user types a wrong value or non numeric values
            if (double.TryParse(first, out double value))
                return value;
            else
                return GetFirstNumber();
        }

        public static double GetSecondNumber()
        {
            Write("Type in the the second number and press Enter: ");
            var second = ReadLine();

            // Check if user types a wrong value or non numeric values
            if (double.TryParse(second, out double value))
                return value;
            else
                return GetSecondNumber();
        }

        public static double CalculateSumOfNumbers(char calculationChoice, double firstNumber, double secondNumber)
        {
            double sum = 0;

            // Switch over if to make it more readable.
            sum = calculationChoice switch
            {
                'A' => AddNumbers(firstNumber, secondNumber),
                'B' => SubtractNumbers(firstNumber, secondNumber),
                'C' => MultiplyNumbers(firstNumber, secondNumber),
                'D' => DivideNumbers(firstNumber, secondNumber),
                // if somehow, an invalid value reaches here.
                // _ tells the compiler to ignore its value
                _ => throw new ArgumentException($"Invalid {nameof(calculationChoice)}"),
            };
            return sum;
        }
    }
}
