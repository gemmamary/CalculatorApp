using System;

namespace Calculator
{
    public class Calculation
    {
        public static double AddNumbers(double first, double second) 
        {
            return first + second;
        } 

        public static double SubtractNumbers(double first, double second) 
        {
            return first - second;
        } 

        public static double MultiplyNumbers(double first, double second) 
        {
            return first * second;
        }

        public static double DivideNumbers(double first, double second) 
        {
            double sum = 0;

            if(second == 0)
            {
                sum = first;
            }
            else
            {
                sum = first / second;
            }

            return sum;
        }

    }
}
