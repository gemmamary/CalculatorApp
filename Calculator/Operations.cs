using System;
using static System.Console;

namespace Calculator
{
    public class Operations
    {
        public static string GetCalculationType()
        {
            WriteLine("\nChoose a calculation type from the list below: \n");

            string[] lettersForCalculation = {"A for Addition", "B for Subtraction", "C for Multiplication", "D for Division"};
            foreach(string v in lettersForCalculation) 
            {
                WriteLine(v);
            }

            var calculationChoice = ReadLine();
            return calculationChoice;
        }

        public static double GetFirstNumber()
        {
            WriteLine("Type in the the first number and press Enter: ");
            var first = ReadLine();

            return double.Parse(first);
        }

        public static double GetSecondNumber()
        {
            WriteLine("Type in the the second number and press Enter: ");
            var second = ReadLine();

            return double.Parse(second);
        }  

        public static double CalculateSumOfNumbers(string calculationChoice, double firstNumber, double secondNumber)
        {
            double sum = 0; 

            if(calculationChoice == "A")
            {
                sum = Calculation.AddNumbers(firstNumber, secondNumber);
            }
                     
            return sum;
        }          
    }
}
