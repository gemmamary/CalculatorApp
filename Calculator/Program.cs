using System;
using static System.Console;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var user = new InstanceUser();
            user.GetUsername();
            user.GreetUser();

            var calculationChoice = Operations.GetCalculationType(); 
            var firstNumber = Operations.GetFirstNumber(); 
            var secondNumber = Operations.GetSecondNumber(); 

            var sumOfNumbers = Operations.CalculateSumOfNumbers(calculationChoice, firstNumber, secondNumber);

            WriteLine($"Sum: {sumOfNumbers}"); 
        }
    }
}
