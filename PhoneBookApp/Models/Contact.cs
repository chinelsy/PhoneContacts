﻿namespace PhoneBookApp.Models
{
    public class Contact
    {
        public Contact(string name, int number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public int Number { get; set; }
    }
}
