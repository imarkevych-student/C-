//Завдання 1
//Виведіть на екран цитату Б'ярна Страуструпа: It's easy to win forgiveness for being wrong; being right is what gets you into real trouble.
//Приклад виводу:
//It's easy to win forgiveness for being wrong; 
//being right is what gets you into real trouble.
//Bjarne Stroustrup
//Завдання 2
//Користувач вводить з клавіатури п'ять чисел. Необхідно знайти суму чисел, максимум і мінімум з п'яти чисел, добуток чисел. Результат обчислень вивести на екран.
//Завдання 3
//Користувач з клавіатури вводить шестизначне число. 
//Необхідно перевернути число і відобразити результат. 
//Наприклад, якщо введено 341256, результат 652143.
//Завдання 4
//Користувач вводить з клавіатури межі числового діапазону. Потрібно показати усі числа Фібоначчі з цього діапазону. Числа Фібоначчі — елементи числової послідовності, у якій перші два числа дорівнюють 0 і 1, а кожне 
//наступне число дорівнює сумі двох попередніх чисел. 
//Наприклад, якщо вказано діапазон 0–20, результат буде: 
//0, 1, 1, 2, 3, 5, 8, 13.
//Завдання 5
//Дано цілі додатні числа A і B (A < B). Вивести усі цілі числа від A до B включно; кожне число має виводитися у новому рядку; при цьому кожне число має виводитися у кількість разів, рівну його значенню. Наприклад: якщо А = 3, а В = 7, то програма має сформувати в консолі такий висновок:
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7
//Завдання 6
//Користувач з клавіатури вводить довжину лінії, символ заповнювач, напрямок лінії (горизонтальна, вертикальна). 
//Програма відображає лінію по заданих параметрах. 
//Наприклад: +++++.
//Параметри лінії: горизонтальна лінія, довжина дорівнює п'яти, символ заповнювач +.

namespace _01_IntroToDotNet_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
    //        //Task01
    //        Console.WriteLine("Завдання 1");
    //        string quote = @"    It's easy to win forgiveness for being wrong;
    //being right is what gets you into real trouble.
    //Bjarne Stroustrup";
    //        Console.WriteLine(quote);
    //        //Task02
    //        Console.WriteLine("Завдання 2");
    //        Console.WriteLine("Введіть 5 чисел:");

    //        int num1, num2, num3, num4, num5;

    //        Console.Write("Число 1: ");
    //        num1 = int.Parse(Console.ReadLine());

    //        Console.Write("Число 2: ");
    //        num2 = int.Parse(Console.ReadLine());

    //        Console.Write("Число 3: ");
    //        num3 = int.Parse(Console.ReadLine());

    //        Console.Write("Число 4: ");
    //        num4 = int.Parse(Console.ReadLine());

    //        Console.Write("Число 5: ");
    //        num5 = int.Parse(Console.ReadLine());
           
    //        int sum = num1 + num2 + num3 + num4 + num5;
           
    //        int min = Math.Min(num1, Math.Min(num2, Math.Min(num3, Math.Min(num4, num5))));
        
    //        int max = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));
       
    //        int dobutok = num1 * num2 * num3 * num4 * num5;
          
    //        Console.WriteLine($"Сума чисел: {sum}");
    //        Console.WriteLine($"Мінімальне число: {min}");
    //        Console.WriteLine($"Максимальне число: {max}");
    //        Console.WriteLine($"Добуток чисел: {dobutok}");

    //        //Task03
    //        Console.WriteLine("Завдання 3");
    //        Console.Write("Введіть шестизначне число: ");
    //        int number = int.Parse(Console.ReadLine());

    //        if (number >= 100000 && number <= 999999)
    //        {
    //            int digit1 = number % 10;          
    //            int digit2 = (number / 10) % 10;   
    //            int digit3 = (number / 100) % 10;  
    //            int digit4 = (number / 1000) % 10; 
    //            int digit5 = (number / 10000) % 10;
    //            int digit6 = number / 100000;     

    //            int reversedNumber = digit1 * 100000 + digit2 * 10000 + digit3 * 1000 + digit4 * 100 + digit5 * 10 + digit6;

    //            Console.WriteLine($"Перевернуте число: {reversedNumber}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Некоректне введення. Введіть шестизначне число.");
    //        }

            //Task04
            //Console.WriteLine("Завдання 4");
            //Console.Write("Введіть нижню межу діапазону: ");
            //int lowerBound = int.Parse(Console.ReadLine());

            //Console.Write("Введіть верхню межу діапазону: ");
            //int upperBound = int.Parse(Console.ReadLine());

            //if (lowerBound > upperBound)
            //{
            //    Console.WriteLine("Помилка: Нижня межа має бути менша або дорівнювати верхній межі.");
            //    return;
            //}

            //Console.WriteLine($"Числа Фібоначчі в діапазоні {lowerBound}-{upperBound}:");

            //int a = 0, b = 1;
            //while (a <= upperBound)
            //{
            //    if (a >= lowerBound)
            //    {
            //        Console.Write(a + " ");
            //    }

            //    int temp = a + b;
            //    a = b;
            //    b = temp;
            //}

            //Task05
            //Console.WriteLine("Завдання 5");
            //Console.Write("Введіть A: ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Введіть B (має бути більше за A): ");
            //int B = int.Parse(Console.ReadLine());

            //if (A < B)
            //{
            //    for (int i = A; i <= B; i++)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            Console.Write(i + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Помилка: A повинне бути меншим за B.");
            //}
            //Task06
            Console.WriteLine("Завдання 6");
            Console.Write("Введіть довжину лінії: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Введіть символ заповнювач: ");
            char fillChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Перехід на новий рядок

            Console.Write("Введіть напрямок (h - горизонтальний, v - вертикальний): ");
            char direction = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Результат:");

            if (direction == 'h')
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fillChar);
                }
                Console.WriteLine();
            }
            else if (direction == 'v')
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fillChar);
                }
            }
            else
            {
                Console.WriteLine("Некоректний напрямок. Введіть 'h' для горизонтальної або 'v' для вертикальної лінії.");
            }

        }
    }
}
