using System;
using static System.Console;
using static Calculator.Calculation;

namespace Calculator
{
    public class Operations
    {
        public static string GetCalculationType()
        {
            WriteLine($"{Environment.NewLine}Choose a calculation type from the list below: ");

            string[] lettersForCalculation = {"A for Addition", "B for Subtraction", "C for Multiplication", "D for Division"};
            
            foreach(string v in lettersForCalculation) 
                WriteLine(v);

            var calculationChoice = ReadLine();
            return calculationChoice;
        }

        public static double GetFirstNumber()
        {
            WriteLine("Type in the the first number and press Enter: ");
            var first = ReadLine();

            if(double.TryParse(first, out double value))
            {
                return value;
            }
            else
            {
                WriteLine("That is an invalid number. Please try again.");
                return GetFirstNumber();
            }

        }

        public static double GetSecondNumber()
        {
            WriteLine("Type in the the second number and press Enter: ");
            var second = ReadLine();

            if (double.TryParse(second, out double value))
            {
                return value;
            }
            else
            {
                WriteLine("That is an invalid number. Please try again.");
                return GetSecondNumber();
            }
        }  

        public static double CalculateSumOfNumbers(string calculationChoice, double firstNumber, double secondNumber)
        {
            double sum = 0; 

            if(calculationChoice == "A")
            {
                sum = AddNumbers(firstNumber, secondNumber);
            }
            else if (calculationChoice == "B")
            {
                sum = SubtractNumbers(firstNumber, secondNumber);
            }
            else if (calculationChoice == "C")
            {
                sum = MultiplyNumbers(firstNumber, secondNumber);
            }
            else if (calculationChoice == "D")
            {
                sum = DivideNumbers(firstNumber, secondNumber);
            }
                     
            return sum;
        }          
    }
}
