namespace _14_Extension_Homework
{
    using System;
    using System.Collections.Generic;

    public static class MyExtensions
    {
        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            input = input.ToLower();
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(input[left]))
                    left++;

                while (left < right && !char.IsLetterOrDigit(input[right]))
                    right--;

                if (input[left] != input[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public static string Encrypt(this string text, int key)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char shifted = (char)(text[i] + key);
                result += shifted;
            }

            return result;
        }

        public static Dictionary<T, int> CountDuplicates<T>(this T[] array)
        {
            var counts = new Dictionary<T, int>();

            for (int i = 0; i < array.Length; i++)
            {
                T current = array[i];

                if (counts.ContainsKey(current))
                    counts[current]++;
                else
                    counts[current] = 1;
            }

            return counts;
        }
    }

    class Program
    {
        static void Main()
        {
            //Task01
            string phrase = "А роза упала на лапу Азора";
            bool palindromeResult = phrase.IsPalindrome();
            Console.WriteLine($"\"{phrase}\" -> Паліндром: {palindromeResult}");
            //Task02
            string originalText = "Привіт";
            int key = 3;
            string encryptedText = originalText.Encrypt(key);
            Console.WriteLine($"\nОригінал: {originalText}");
            Console.WriteLine($"Зашифровано (ключ {key}): {encryptedText}");
            //Task03
            int[] numbers = { 1, 3, 1, 4, 3, 5, 1 };
            var duplicateCount = numbers.CountDuplicates();

            Console.WriteLine("\nПовторення в масиві:");
            foreach (var pair in duplicateCount)
            {
                Console.WriteLine($"Елемент {pair.Key}: {pair.Value} разів");
            }
        }
    }
}
