//Завдання 4:
//Додаток генерує випадковим чином 10000 цілих чисел. 
//Збережіть парні числа в один файл, непарні – в інший. За 
//підсумками роботи додатка потрібно відобразити статистику на 
//екрані.
//Завдання 5:
//Додаток надає користувачеві можливість пошуку по файлу:
// Пошук заданого слова. Додаток показує, чи знайдено слово. 
//Крім того, відображається інформація про те, де знайдено 
//збіг.
// Пошук кількості входження слова у файл. Додаток 
//відображає кількість знайденого слова.
// Пошук заданого слова у зворотному порядку. Наприклад,
//користувач шукає слово «moon». Це означає, що додаток 
//шукає слово «moon» у зворотному напрямку: «noom». За 
//результатами пошуку, додаток відображає кількість 
//входжень.
//Завдання 6:
//Користувач вводить шлях до файлу. Додаток відображає
//статистичну інформацію про файл:
// кількість речень;
// кількість великих літер;
// кількість маленьких літер;
// кількість голосних літер;
// кількість приголосних літер;
// кількість цифр

using Modules;
using System;
using System.IO;
class Program
{  
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        var lines = new[] {
        "The moon glows softly at night.",
        "I saw the moon again and again.",
        "Have you ever looked at the moon from a telescope?",
        "Some people believe 'noom' is a reversed form of moon.",
        "Digits like 123 and 456 appear here.",
        "A proper sentence ends here!",
        "CAN YOU COUNT UPPERCASE letters AND lowercase ones?",
        "Why not search for something hidden... like the word moon?"
        };

        string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "text.txt");
        File.WriteAllLines(filePath, lines);

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);            
        }
        else
        {
            Console.WriteLine("Файл не знайдено: " + filePath);
        }

        var numberProcessor = new NumberProcessor();
        var textSearcher = new TextSearcher();
        var textAnalyzer = new TextAnalyzer();

        numberProcessor.Execute();
        Console.WriteLine();

        textSearcher.Execute(filePath, "moon");
        Console.WriteLine();

        textAnalyzer.Execute(filePath);
    }
}

