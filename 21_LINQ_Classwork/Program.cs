//1: Дано цілочисельну послідовність. Витягти з неї всі позитивні числа,відсортувавши їх по зростанню. (можна використати Where, OrderBy)
//2: Дано колекцію цілих чисел. Знайти кількість позитивних двозначних елементів,  а також їх середнє арифметичне. (Where, Avg)
using System;
using System.Linq;
using System.Collections.Generic;

namespace _21_LINQ_Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, 3, 12, -1, 7, 20, -8, 15, 0, 9 };
            var positiveNumbers = numbers
                .Where(n => n > 0)
                .OrderBy(n => n)
                .ToList();

            Console.WriteLine("Позитивні числа, відсортовані по зростанню:" + string.Join(", ", positiveNumbers));

            var twoDigitPositiveNumbers = numbers
                .Where(n => n > 0 && n >= 10 && n < 100)
                .ToList();  
            int countTwoDigitPositive = twoDigitPositiveNumbers.Count;
            double averageTwoDigitPositive = twoDigitPositiveNumbers.Any() ? twoDigitPositiveNumbers.Average() : 0;

            Console.WriteLine($"Кількість позитивних двозначних чисел: {twoDigitPositiveNumbers.Count}");
            Console.WriteLine($"Середнє арифметичне позитивних двозначних чисел: {averageTwoDigitPositive:F2}");
        }
    }
}
