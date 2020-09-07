using System;
using static System.Console;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var currentUser = User.GetUsername();
            User.GreetUser(currentUser);
 
            var firstNumber = Operations.GetFirstNumber(); 
            var secondNumber = Operations.GetSecondNumber();

            var sumOfNumbers = Operations.CalculateSumOfNumbers(firstNumber, secondNumber);

            WriteLine($"{Environment.NewLine}Sum: {sumOfNumbers}"); 
        }
    }
}
