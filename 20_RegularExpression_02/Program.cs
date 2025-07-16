namespace _20_RegularExpression_02
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

            string pattern = @"\d+";

            MatchCollection matches = Regex.Matches(content, pattern);

            List<int> integers = new List<int>();

            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    integers.Add(number);
                }
            }
            Console.WriteLine("Знайдені цілі числа:");
            foreach (int number in integers)
            {
                Console.WriteLine(number);
            }


        }
    }
}