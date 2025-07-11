//Завдання 1:
//Додаток дозволяє користувачеві переглядати вміст файлу. Користувач вводить шлях до файлу. Якщо файл існує, його вміст відображається на екрані. Якщо файл не існує, виведіть повідомлення про помилку.
//Завдання 2:
//Користувач вводить значення елементів масиву з клавіатури. Додаток надає можливість зберігати вміст масиву у файл.
//Завдання 3:
//Додайте до другого завдання можливість завантажувати масив із файлу.

using System;

namespace _18_03_Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            // Завдання 1: Перегляд вмісту файлу
            Console.Write("Введіть шлях до файлу:");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("Вміст файлу:\n" + content);
                }
            }
            else
            {
                Console.WriteLine("Файл не існує.");
            }
            // Завдання 2: Збереження масиву у файл
            Console.Write("Скільки елементів ви хочете ввести? ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Введіть ім’я файлу для збереження: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (int num in array)
                    writer.WriteLine(num);
            }

            Console.WriteLine("Масив збережено у файл.");

            // Завдання 3: Завантаження масиву з файлу
            Console.Write("Введіть ім’я файлу для завантаження: ");
            string loadFile = Console.ReadLine();

            if (File.Exists(loadFile))
            {
                List<int> list = new List<int>();

                using (StreamReader reader = new StreamReader(loadFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                        list.Add(int.Parse(line));
                }

                Console.WriteLine("Завантажений масив:");
                foreach (var num in list)
                    Console.Write(num + " ");
            }
            else
            {
                Console.WriteLine("Файл не знайдено.");
            }

        }
    }
}