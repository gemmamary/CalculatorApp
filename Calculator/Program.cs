using System;
using static System.Console;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine(User.GreetUser(User.GetUsername()));

            WriteLine("\nChoose a calculation type from the list below: \n");

            string[] lettersForCalculation = {"A for Addition", "B for Subtraction", "C for Multiplication", "D for Division"};
            foreach(string v in lettersForCalculation) 
            {
                WriteLine(v);
            }

            var calculationChoice = ReadLine();

            WriteLine(calculationChoice);  

            WriteLine("Type in the the first number and press Enter: ");
            var first = ReadLine();

            WriteLine("Type in the the second number and press Enter: ");
            var second = ReadLine();

            int sum = 0; 

            if(calculationChoice == "A")
            {
                sum = Calculation.AddNumbers(Int32.Parse(first), Int32.Parse(second));
            }
                     
            WriteLine(sum);

            /*
                - 'Enter two numbers seperated by a comma'
                - Output 'Sum of Numbers: ' 
            */ 

            

        }
    }
}
