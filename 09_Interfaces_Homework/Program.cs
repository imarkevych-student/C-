//Завдання 3
//Створіть інтерфейс ISort. У ньому мають бути три методи:
//■ void SortAsc() — сортування за зростанням;
//■ void SortDesc() — сортування за зменшенням;
//■ void SortByParam(bool isAsc) — сортування залежно  ід переданого параметра. Якщо isAsc дорівнює true, сортуємо за зростанням. Якщо isAsc дорівнює false, сортуємо за зменшенням.

//Клас, створений у першому завданні Array, має імплементувати інтерфейс ISort. 
//Метод SortAsc — сортує масив за зростанням.
//Метод SortDesc — сортує масив за спаданням.
//Спосіб SortByParam — сортує масив залежно від переданого параметра. Якщо isAsc дорівнює true, сортуємо за зростанням. Якщо isAsc дорівнює false, сортуємо за зменшенням.
//Напишіть код для тестування отриманої функціональності.

namespace _09_Interfaces_Homework
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }

    class Array : IOutput, ISort
    {
        private int[] data;
        public Array(int[] values)
        {
            data = (int[])values.Clone();
        }
        public void Show()
        {
            Console.WriteLine("Масив: " + string.Join(", ", data));
        }
        public void Show(string info)
        {
            Console.WriteLine($"{info}\nМасив: {string.Join(", ", data)}");
        }

        public void SortAsc() => data = data.OrderBy(x => x).ToArray();
        public void SortDesc() => data = data.OrderByDescending(x => x).ToArray();    
        public void SortByParam(bool isAsc) => data = isAsc ? data.OrderBy(x => x).ToArray() : data.OrderByDescending(x => x).ToArray();


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int[] nums = { 10, 20, 5, 40, 15, 60, 70 };
            Array arr = new Array(nums);

            arr.Show("Початковий масив:");
            arr.SortAsc();
            arr.Show("Після сортування за зростанням:");
            arr.SortDesc();
            arr.Show("Після сортування за спаданням:");
            arr.SortByParam(true);
            arr.Show("Після сортування за зростанням (через параметр):");
            arr.SortByParam(false);
            arr.Show("Після сортування за спаданням (через параметр):");                     
        }
    }    
}
