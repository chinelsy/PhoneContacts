using PhoneBookApp.Models;
using System;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display contact by number");
            Console.WriteLine("3. View all contacts");
            Console.WriteLine("4. Search for contacts for a given name");
            Console.WriteLine("Press 'x' to exit");

            var userInput = Console.ReadLine();
            var phoneBook = new PhoneBook();
            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(" Contact name");
                        var name = Console.ReadLine();
                        Console.WriteLine(" Contact number");
                        var number = Convert.ToInt32(Console.ReadLine());
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine(" Contact number to Search");
                      var Searchnumber = Convert.ToInt32(Console.ReadLine());
                        phoneBook.DisplayContact(Searchnumber);
                        break;

                    case "3":
                        phoneBook.DisplayContacts();
                        break;

                    case "4":
                        Console.WriteLine("Search for Contact");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;

                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                Console.WriteLine("Select Operation");
                userInput = Console.ReadLine();
            }
         
        }
    }
}
