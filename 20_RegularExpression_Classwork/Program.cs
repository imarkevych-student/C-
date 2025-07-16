//1.Програма повинна знайти в текстовому файлі всі дробові числа. 
//Дробовим вважається число, в якого є значення після символу .
//(крапка) або ,(кома).
//2.Написати програму, яка буде зчитувати вміст текстового файлу 
//та записувати в колекцію типу int всі знайдені числа в тексті.
namespace _20_RegularExpression_Classwork
{
    using System;
    using System.Text.RegularExpressions;
    using System.IO;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            string filePath = "numbers.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не знайдено.");
                return;
            }

            string content = File.ReadAllText(filePath);

            string decimalPattern = @"\d+[\.,]\d+";

            MatchCollection matches = Regex.Matches(content, decimalPattern);

            List<string> decimalNumbers = new List<string>();

            foreach (Match match in matches)
            {
                decimalNumbers.Add(match.Value);
            }

            Console.WriteLine("Знайдені дробові числа:");
            foreach (string number in decimalNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
