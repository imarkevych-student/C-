//Task 3:
//Дано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.
//Task 4:
//Дано масив слів. Замінити останні три символи слів, що мають обрану довжину, на символ "$"

//Task 5:
//Знайти слово, що стоїть в тексті під певним номером, і вивести його першу букву.
//Task 6:
//Дано рядок слів, розділених пробілами. Між словами може бути кілька пробілів, на початку і вкінці рядка також можуть бути пробіли. Ви повинні змінити рядок так, щоб на початку і вкінці пробілів не було, а слова були розділені поодиноким символом "*" (зірочка).
//Task 7:
//Користувач вводить слова, поки не буде введено слово з символом крапки вкінці. Сформувати з введених слів рядок, розділивши їх комою з пробілом. Застосувати StringBuilder.
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03_04_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Task03
            //Console.WriteLine("Завдання 03");
            //Console.Write("Введіть довільний рядок:");
            //int countLowCase = 0, countUpperCase = 0;
            //double pcntLowCase=0, pcntUpperCase=0;
            //string str = Console.ReadLine();
            //foreach(char ch in str )
            //{
            //    if(char.IsLower(ch))
            //        countLowCase++;
            //    if(char.IsUpper(ch))
            //        countUpperCase++;
            //}
            //pcntLowCase = (double)countLowCase / str.Length * 100;
            //pcntUpperCase = (double)countUpperCase / str.Length * 100;
            //Console.WriteLine($"Кількість символів у нижньому регістрі: {countLowCase}, у відстоках: {pcntLowCase:f2}%");
            //Console.WriteLine($"Кількість символів у нижньому регістрі: {countUpperCase}, у відстоках: {pcntUpperCase:f2}%");

            //Task04
            //Console.WriteLine("Завдання 04");
            //Console.WriteLine("Введіть кількість слів:");
            //int size = int.Parse(Console.ReadLine());

            //string[] words = new string[size];
            //string temp = "";
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Введіть слово {i + 1}: ");
            //    words[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    if (words[i].Length == 5)
            //    {
            //        temp = words[i];
            //        string modifiedWord = temp.Substring(0, temp.Length - 3) + "$$$";
            //        words[i] = modifiedWord;
            //    }                 

            //}

            //Console.WriteLine("Модифіковані слова:");
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}
            //Task05
            //Console.WriteLine("Завдання 05");
            //Console.Write("Введіть текст:");
            //string text = Console.ReadLine();
            //Console.Write("Введіть номер слова:");
            //int wordIndex   = int.Parse(Console.ReadLine())-1;
            //string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            //if (wordIndex>=0 && wordIndex < words.Length)
            //{
            //    Console.WriteLine($"Перша літера слова #{wordIndex+1}: {words[wordIndex][0]}");
            //} else
            //{
            //    Console.WriteLine("Неправильний номер слова."); 
            //}
            //// Task06
            //Console.WriteLine("Завдання 06");
            //Console.Write("Введіть текст:");
            //string text = Console.ReadLine();
            //string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            //string modifiedText = string.Join("*", words);
            //Console.WriteLine(modifiedText);

            // Task07
            Console.WriteLine("Завдання 07");
            StringBuilder result = new StringBuilder();
            Console.WriteLine("Вводьте слова (завершиться при введенні слова з крапкою):");
            while (true)
            {
                string word = Console.ReadLine();
                if (word.EndsWith("."))
                {
                    result.Append(word);
                    break;
                }
                else
                {
                    if (result.Length > 0)
                    {
                        result.Append(", ");
                    }
                    result.Append(word);
                }
            }
            Console.WriteLine($"Форматований рядок: {result}");
        }
    }
}
