using PhoneBookApp.Models;
using System;
using System.Linq;

namespace PhoneBookApp
{
    public static class Application
    {
        public static void Run()
        {
            Console.WriteLine("WELCOME\n");
            Console.WriteLine("Select Operation\n");
            Console.WriteLine("1. Add Contact\n");
            Console.WriteLine("2. Display contact by number\n");
            Console.WriteLine("3. View all contacts\n");
            Console.WriteLine("4. Search for contacts for a given name\n");
            Console.WriteLine("5. Delete a Contact\n");
            Console.WriteLine("Press 'x' to exit\n");

            try
            {
                var userInput = Console.ReadLine();
                var phoneBook = new PhoneBook();
                while (true)
                {
                    switch (userInput)
                    {
                        //Validation for Name
                        case "1":
                            Console.WriteLine(" Contact name");
                            var name = Console.ReadLine();
                            if (string.IsNullOrEmpty(name))
                            {
                                Validation.EmptyPrompt("name");
                            }
                            else if (name.Length < 2)
                            {
                                Validation.LessThanTwoPrompt("name");
                            }
                            else if (name.Any(c => char.IsDigit(c)))
                            {
                                Validation.ContainsNumber("name");
                            }

                           //Validation for Number
                            Console.WriteLine(" Contact number");
                            var number = Console.ReadLine();
                            if (string.IsNullOrEmpty(number))
                            {
                                Validation.EmptyPrompt("number");
                            }
                            else if(number != null)
                            {
                                Validation.IsValidPhoneNumber(number);
                            }
                            var newContact = new Contact(name, number);
                            phoneBook.AddContact(newContact);
                            break;

                        case "2":
                            Console.WriteLine(" Contact number to Search");
                            var Searchnumber = Console.ReadLine();
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

                        case "5":
                            Console.WriteLine("enter the contact name to delete");
                            var contact = Console.ReadLine();
                            phoneBook.RemoveContact(contact);
                            Console.WriteLine("Deleted");
                            break;

                        case "x":
                            return;
                        default:
                            Console.WriteLine("Select valid operation");
                            break;
                    }
                    Console.WriteLine("Select Operation");
                    Validation.DisplayInfo();
                    userInput = Console.ReadLine();
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

    }
}
