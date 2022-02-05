using System;
using System.Text.RegularExpressions;

namespace PhoneBookApp
{
    public static class Validation
    {
        //Donot leave any option blank
        public static void EmptyPrompt(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot be empty, Re-enter your {field}");
        }

        public static void LessThanTwoPrompt(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot be less than 2 characters, Re-enter your {field}");
        }

        public static void ContainsNumber(string field)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot contain nmbers, Re-enter your {field}");
        }

     
        public static bool IsValidPhoneNumber(string number)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
            Regex regex = new Regex(strRegex);
            if (regex.IsMatch(number))
                return (true);
            else
                return (false);
        }

        public static void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }



    }
}
