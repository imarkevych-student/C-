using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace Modules
{
    public class TextAnalyzer
    {
        public void Execute(string filePath)
        {
            string content = File.ReadAllText(filePath);
            int sentenceCount = Regex.Matches(content, @"[.!?]").Count;
            int upperCaseCount = content.Count(char.IsUpper);
            int lowerCaseCount = content.Count(char.IsLower);
            int vowelCount = content.Count(c => "aeiouyAEIOUY".Contains(c));
            int consonantCount = content.Count(c => char.IsLetter(c) && !"aeiouyAEIOUY".Contains(c));
            int digitCount = content.Count(char.IsDigit);
            Console.WriteLine("[TextAnalyzer]");
            Console.WriteLine($"Кількість речень: {sentenceCount}");
            Console.WriteLine($"Кількість великих літер: {upperCaseCount}");
            Console.WriteLine($"Кількість маленьких літер: {lowerCaseCount}");            
            Console.WriteLine($"Кількість голосних літер: {vowelCount}");
            Console.WriteLine($"Кількість приголосних літер: {consonantCount}");
            Console.WriteLine($"Кількість цифр: {digitCount}");

        }
    }
}
