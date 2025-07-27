using System;
using System.Collections.Generic;

namespace _15_Dictionary_Homework
{
    public class Phonebook
    {
        private Dictionary <string, string> contacts = new Dictionary <string, string> ();

        public void AddContact(string name, string phoneNumber)
        {
            if (contacts.ContainsKey(name))
            { 
                contacts [name] = phoneNumber;
                Console.WriteLine($"Додано: {name} - {phoneNumber}");
            }
            else
            {
                Console.WriteLine($"Контакт {name} вже існує.");

            }
        }

        public void UpdateContact(string name, string newPhoneNumber)
        {
            if (contacts.ContainsKey(name))
            {
                contacts[name] = newPhoneNumber;
                Console.WriteLine($"Оновлено: {name} - {newPhoneNumber}");
            }
            else
            {
                Console.WriteLine($"Контакт {name} не знайдено.");
            }
        }

        public void SearchContact(string name)
        {
            if (contacts.TryGetValue(name, out string phoneNumber))
            { 
                Console.WriteLine($"Контакт знайдено: {name} - {phoneNumber}");
            }
            else
            {
                Console.WriteLine($"Контакт {name} не знайдено.");
            }
        }

        public void DeleteContact(string name)
        {
            if (contacts.Remove(name))
            {
                Console.WriteLine($"Контакт {name} видалено.");
            }
            else
            {
                Console.WriteLine($"Контакт {name} не знайдено.");
            }
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Телефонна книга порожня.");
                return;
            }
            Console.WriteLine("Телефонна книга:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key} - {contact.Value}");
            }
        }
    }
}
