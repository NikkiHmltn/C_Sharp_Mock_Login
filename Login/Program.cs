using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //user login system where the user can register then login
            //program should check if the user has entered the correct username and password at login
            //register and login happen at same time

            Welcome();
        }

        public static void Welcome()
        {
            string choice;
            Console.WriteLine("Would you like to login, or register? login/register");
            choice = Console.ReadLine();
            if (choice == "login")
            {
                Login();

            }
            else if (choice == "register")
            {
                Register();
            }
            else
            {
                Console.WriteLine("I'm sorry, I don't understand what you're saying. Please try again.");
                Welcome();
            }

        }

        public static void Register()
        {
            string username;
            string password;
            string checkPassword;
            Console.WriteLine("Enter a username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter a password");
            password = Console.ReadLine();
            Console.WriteLine("Please enter your password again to confirm it.");
            checkPassword = Console.ReadLine();

            if (password == checkPassword)
            {
                AutoLogin(username);
            } else
            {
                Console.WriteLine("Passwords do not match. Restarting registration.");
                Register();
            }

        }

        public static void AutoLogin(string username)
        {
            Console.WriteLine("Welcome, {0}. You are logged in!", username);
        }

        public static void Login()
        {
            string username;
            string password;
            string checkPassword;
            Console.WriteLine("Enter a username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter a password");
            password = Console.ReadLine();
            Console.WriteLine("Please enter your password again to confirm it.");
            checkPassword = Console.ReadLine();

            if (password == checkPassword)
            {
                AutoLogin(username);
            }
            else
            {
                Console.WriteLine("Passwords do not match. Restarting Login process.");
                Login();
            }
        }
    }
}
