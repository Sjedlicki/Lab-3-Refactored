using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        //public static string userName = UserName();
        //private static int num;
        static void Main(string[] args)
        {
            // INTRODUCTION
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Hello there, what's your name? ");
            string userName = UserName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nice you meet you, " + userName);
            Console.ForegroundColor = ConsoleColor.Blue;

            bool isValid = true;
            while (isValid == true)
            {
                Console.Write("Please select an integer between 1 and 100: ");

                int.TryParse(Console.ReadLine(), out int num);

                if (Odd(num) == true)
                {
                    Console.WriteLine(userName +" your number is " + num + " and odd");
                }
                else if (Even(num) == true)
                {
                    Evens(num, userName);                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                isValid = Continue(userName);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // METHOD FOR VALIDATING ODD NUMBERS
        public static bool Odd(int x)
        {
            if ((x % 2 == 1) && (x >= 1) && (x <= 100))
            {
                return true;
            }
            return false;
        }
        // METHOD FOR VALIDATING EVEN NUMBERS
        public static bool Even(int x)
        {
            if (x % 2 == 0 && x >= 1 && x <= 100)
            {
                return true;
            }
            return false;
        }

        public static string UserName()
        {
            return Console.ReadLine();
        }
        // METHOD FOR EVALUATING EVEN NUMBERS
        public static void Evens(int num, string userName)
        {
            if ((num % 2 == 0) && (num <= 25) && (num >= 2))
            {
                Console.WriteLine(userName + " your number is: " + "Even and Less Than 25");
            }
            else if ((num % 2 == 0) && (num >= 26) && (num <= 60))
            {
                Console.WriteLine(userName + " your number is: " + "Even");
            }
            else if ((num % 2 == 0) && (num > 60) && (num <= 100))
            {
                Console.WriteLine(userName + " your number is: " + num + " and Even");
            }
        }
        // CONTINUE LOOP USING RECURCSION
        public static bool Continue(string userName)
        {
            Console.Write("Would you like to select another integer " + userName + " (y/n)? ");
            string repeat = Console.ReadLine().ToLower();
            if (repeat == "y" || repeat == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (repeat == "n" || repeat == "no" || repeat == "exit")
            {
                Console.WriteLine("Thanks for your sweet inputs today " + userName + "\nHave a great day!");
                return false;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I'm sorry, I didn't understand that, try again");
            Console.ForegroundColor = ConsoleColor.Blue;
            return Continue(userName);            
        }
    }
}