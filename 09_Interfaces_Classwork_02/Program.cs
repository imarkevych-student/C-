//Завдання 2
//Створіть інтерфейс IMath. У ньому мають бути чотири методи:
//■ int Max() — повертає максимум;
//■ int Min() — повертає мінімум;
//■ float Avg() — повертає середньоарифметичне;
//■ bool Search(int valueToSearch) — шукає valueSearch всередині контейнера даних. Повертає true, якщо 
//значення знайдено. Повертає false, якщо значення не знайдено.
//Клас, створений у першому завданні Array, має імплементувати інтерфейс IMath. 
//Метод Max — повертає максимум серед елементів масиву.
//Метод Min — повертає мінімум серед елементів масиву.
//Метод Avg — повертає середньоарифметичне серед елементів масиву.
//Метод Search — шукає значення всередині масиву. 
//Повертає true, якщо значення знайдено. Повертає false, якщо значення не знайдено.
//Напишіть код для тестування отриманої функціональності
namespace _09_Interfaces_Classwork_02
{
    interface IMath 
    {
        int Max();
        int Min();
        double Avg();
        bool Search(int valueToSearch);
    }
    class Array2 : IMath
    {
        private int[] data;

        public Array2(int[] values)
        {
            data = (int[])values.Clone();
        }      

        public int Max() => data.Max();
        public int Min() => data.Min();
        public double Avg() => data.Average();
        public bool Search(int valueToSearch) => data.Contains(valueToSearch);       

   
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int[] nums = { 10, 20, 30, 40, 50 };
            Array2 arr = new Array2(nums);

            Console.WriteLine("Max: " + arr.Max());
            Console.WriteLine("Min: " + arr.Min());
            Console.WriteLine("Avg: " + arr.Avg());
            Console.WriteLine("Search 20: " + arr.Search(20));
            Console.WriteLine("Search 100: " + arr.Search(100));
        }
    }
}
