using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Modules
{
    public class TextSearcher
    {
        public void Execute(string filePath, string searchWord)
        {
            string content = File.ReadAllText("Data/text.txt"); 
            string reversedContent = new string(searchWord.Reverse().ToArray());

            bool found = content.Contains(searchWord);
            int count = Regex.Matches(content, searchWord).Count;
            int reversedCount = Regex.Matches(content, reversedContent).Count;

            Console.WriteLine("[TextSearcher]");
            Console.WriteLine($"Звичайне слово: \"{searchWord}\" — знайдено: {(found ? "так" : "ні")}");
            Console.WriteLine($"Кількість входжень: {count}");
            Console.WriteLine($"Перевернуте слово: \"{reversedContent}\" — знайдено {reversedCount} раз(ів)");
        }
    }
}
