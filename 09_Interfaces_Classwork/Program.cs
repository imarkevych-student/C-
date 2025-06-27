//Завдання 1
//Створіть інтерфейс IOutput. У ньому мають бути два методи:
//■ void Show() — відображає інформацію;
//■ void Show(string info) — відображає інформацію та інформаційне повідомлення, зазначене у параметрі info.
//Створіть клас Array (масив цілого типу) із необхідними методами. Цей клас має імплементувати інтерфейс 
//IOutput.
//Метод Show() — відображає на екран елементи масиву.
//Метод Show(string info) — відображає на екрані елементи масиву та інформаційне повідомлення, зазначене у параметрі info.
//Напишіть код для тестування отриманої функціональності.
namespace _09_Interfaces_Classwork
{
    interface IOutput
    {
        void Show();
        void Show(string info);
    }

    class Array : IOutput
    {
        private int[] data;
        public Array(int[] values)
        {
            data = (int[])values.Clone();
        }
        public void Show() 
        {
            Console.WriteLine("Масив: " + string.Join(", ",data));
        }
        public void Show(string info) 
        {
            Console.WriteLine($"{info}\nМасив: {string.Join(", ",data)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int[] nums = { 3, 8, 1, 6 };
            Array arr = new Array(nums);

            arr.Show();
            arr.Show("Інформаційне повідомлення:");
        }
    }
}
