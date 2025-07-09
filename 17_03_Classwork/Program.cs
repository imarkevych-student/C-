//Завдання 1
//Створіть generic-версію методу обчислення максимуму з трьох чисел.
//Завдання 2
//Створіть generic-версію методу обчислення мінімуму з трьох чисел.
//Завдання 3
//Створіть generic-версію методу пошуку суми елементів у масиві.
namespace _17_03_Classwork
{
    internal class Program
    {
        public static T MaxOfThree<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }

        public static T MinOfThree<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;
            if (b.CompareTo(min) < 0)
            {
                min = b;
            }
            if (c.CompareTo(min) < 0)
            {
                min = c;
            }
            return min;
        }

        public static T SumArray<T>(T[] array)
        {
           dynamic sum = default(T);
            foreach (var item in array)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int maxInt = MaxOfThree(10, 25, 17);
            Console.WriteLine($"Максимум з трьох цілих: {maxInt}");

            double maxDouble = MaxOfThree(3.14, 2.71, 4.56);
            Console.WriteLine($"Максимум з трьох дробових: {maxDouble}");
            
            int minInt = MinOfThree(10, 25, 17);
            Console.WriteLine($"Мінімум з трьох цілих: {minInt}");

            double minDouble = MinOfThree(3.14, 2.71, 4.56);
            Console.WriteLine($"Мінімум з трьох дробових: {minDouble}");
            
            int[] intArray = { 1, 2, 3, 4, 5 };
            int sumInt = SumArray(intArray);
            Console.WriteLine($"Сума цілих чисел: {sumInt}");

            double[] doubleArray = { 1.1, 2.2, 3.3 };
            double sumDouble = SumArray(doubleArray);
            Console.WriteLine($"Сума дробових чисел: {sumDouble}");
        }
    }
}
