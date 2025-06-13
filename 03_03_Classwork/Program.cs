//Task 1:
//Вставити в задану позицію рядка інший рядок.
//Task 2:
//Визначити, чи є рядок паліндромом. Паліндром – це число, слово або фраза, яка однаково читається в обох напрямках.
//Task 3:
//Дано текст. Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.
//Task 4:
//Дано масив слів. Замінити останні три символи слів, що мають обрану довжину, на символ "$"
using System.Linq;
using System;



namespace _03_03_Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Task01
            Console.WriteLine("Завдання 01");
            Console.Write("Введіть рядок:");
            string str = Console.ReadLine();
            Console.Write("Введіть рядок для вставки:");
            string insertStr = Console.ReadLine();
            Console.WriteLine($"Введіть позицію меншу за довжину рядка {str.Length}");
            int position = int.Parse(Console.ReadLine());
            string strOut = str.Insert(position, insertStr);
            Console.WriteLine("Фінальний рядок" + strOut);

            //Task02
            Console.WriteLine("Завдання 02");
            Console.Write("Введіть рядок:");
            string str1 = Console.ReadLine().ToLower();
            string str2 = new string(str1.Reverse().ToArray());
            if (str1 == str2)
                Console.WriteLine("Слово паліндром");
            else
                Console.WriteLine("Слово не паліндром");
        }
    }
}
