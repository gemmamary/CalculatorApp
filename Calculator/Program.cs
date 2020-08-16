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

            var calculationChoice = Operations.GetCalculationType(); 
            var firstNumber = Operations.GetFirstNumber(); 
            var secondNumber = Operations.GetSecondNumber(); 

            var sumOfNumbers = Operations.CalculateSumOfNumbers(calculationChoice, firstNumber, secondNumber);

            WriteLine($"Sum: {sumOfNumbers}");


            /*
                - 'Enter two numbers seperated by a comma'
                - Output 'Sum of Numbers: ' 
            */ 
        }
    }
}
