//Описати клас з ім'ям Worker, що містить наступні поля:
//прізвище та ініціали працівника;
//вік працівника;
//ЗП працівника;
//дата прийняття на роботу.
//Написати програму, що виконує наступні дії:
//введення з клавіатури даних в масив, що складається з п'яти елементів типу Worker (записи повинні бути впорядковані за алфавітом);
//якщо значення якогось параметру введено не в відповідному форматі - згенерувати відповідний exception.
//вивід на екран прізвища працівника, стаж роботи якого перевищує введене з клавіатури значення.
//Рекомендація: перевірку формата даних та генерацію винятку виконуйте в блоці set{} для кожної властивості класа Worker. 
using System;
namespace _05_StructRefOut_Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Worker[] workers  = new Worker[1];

            for (int i = 0; i < workers.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Введіть дані працівника {i + 1}:");
                    Console.Write("Прізвище:");
                    string lastName = Console.ReadLine();
                    Console.Write("Ім`я:");
                    string firstName = Console.ReadLine();
                    Console.Write("Вік:");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Зарплата:");
                    decimal salary = decimal.Parse(Console.ReadLine());
                    Console.Write("Дата прийняття на роботу (yyyy-MM-dd): ");
                    DateTime hireDate;
                    while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out hireDate) || hireDate > DateTime.Now)


                    {
                        Console.WriteLine("Помилка! Введіть правильну дату у форматі yyyy-MM-dd, яка не є у майбутньому:");
                    }

                    workers[i] = new Worker(lastName, firstName, age, salary, hireDate);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }    

                
            }

            Console.Write("Введіть мінімальний стаж роботи:");
            int minExperience = int.Parse(Console.ReadLine());
            Console.WriteLine($"Працівники зі стажем більше {minExperience} років:");

            foreach (Worker worker in workers) 
            {
                if (worker.GetWorkExperience() > minExperience) 
                {
                    Console.WriteLine(worker.WorkerName);
                }
            }
        }
    }
}
