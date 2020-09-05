using static System.Console;

namespace Calculator
{
    public class User
    {
        private static string _user;

        public static void GetUsername()
        {
            // Since it's a local app, you can store the user name in this class.
            // Static class always have the same value.
            // Or can be used per instance, no needs for static methods
            // Also, Write so it makes easier for the user to read.
            WriteLine("Please enter your name: ");
            _user = ReadLine();
        }

        public static void GreetUser()
        {
            WriteLine($"Greetings {_user}! I am a calculator, here to solve all your numeric needs!");
        }
    }

    public class InstanceUser
    {
        private string _user;

        public void GetUsername()
        {
            // Since it's a local app, you can store the user name in this class.
            // Static class always have the same value.
            // Or can be used per instance, no needs for static methods
            // Also, Write so it makes easier for the user to read.
            Write("Please enter your name: ");
            _user = ReadLine();
        }

        public void GreetUser()
        {
            WriteLine($"Greetings {_user}! I am a calculator, here to solve all your numeric needs!");
        }
    }
}

