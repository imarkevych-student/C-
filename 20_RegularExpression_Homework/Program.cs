using System;
using System.Text.RegularExpressions;
namespace _20_RegularExpression_Homework
{  
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть email: ");
            string email = Console.ReadLine();

            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            bool isEmailValid = ValidateEmail(email);
            bool isPasswordValid = ValidatePassword(password);

            Console.WriteLine("\nРезультати перевірки:");
            Console.WriteLine($"Email: {(isEmailValid ? "Коректний" : "Некоректний")}");
            Console.WriteLine($"Пароль: {(isPasswordValid ? "Коректний" : "Некоректний")}");
        }

        static bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return false;

            string[] parts = email.Split('@');
            if (parts.Length != 2)
                return false;

            string name = parts[0];
            string domain = parts[1];
            
            if (!Regex.IsMatch(name, @"^[a-zA-Z0-9._-]{4,}$"))
                return false;
           
            if (domain.Length < 2 || !domain.Contains("."))
                return false;
            
            if (!Regex.IsMatch(domain, @"^[a-zA-Z0-9.]+$"))
                return false;

            return true;
        }
        static bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
                return false;
            
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9_-]+$"))
                return false;
            
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;
            
            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;
            
            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;
           
            if (!Regex.IsMatch(password, @"[_-]"))
                return false;

            return true;
        }
    }
}
