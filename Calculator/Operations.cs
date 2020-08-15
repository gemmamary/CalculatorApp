using System;

namespace Calculator
{
    public class Operations
    {
        public static char GetCalculationType()
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

        

            

            
    }
}
