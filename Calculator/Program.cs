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

            WriteLine(calculationChoice); 
            var firstNumber = Operations.GetFirstNumber(); 
            var secondNumber = Operations.GetSecondNumber(); 


            /*
                - 'Enter two numbers seperated by a comma'
                - Output 'Sum of Numbers: ' 
            */ 
        }
    }
}
