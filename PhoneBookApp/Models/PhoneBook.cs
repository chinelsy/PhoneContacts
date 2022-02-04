using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookApp.Models
{
    public class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        private static void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact:{contact.Name}, {contact.Number}");

        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact); 
        }

        public void DisplayContact(int number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContacts()
        {
            foreach (var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        //This method searches for a given contact
        //named: bill
        //searchphrase: ll
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            foreach (var contact in matchingContacts)
            {
                DisplayContactDetails(contact);
            }
        }
    }
}
