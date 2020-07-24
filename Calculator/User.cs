using static System.Console;

namespace Calculator
{
    public class User
    {
        public static string GetUsername()
        {
            WriteLine("Please enter your name: ");
            return ReadLine();
        }

        public static string GreetUser(string username)
        {
            return $"Greetings {username}! I am a calculator, here to solve all your numeric needs!";
        }


    }
}

