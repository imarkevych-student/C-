//Завдання 1
//Користувач вводить до рядка з клавіатури набір символів від 0-9. Необхідно перетворити рядок на число цілого типу. Передбачити випадок виходу за межі діапазону, який визначається типом int. Використовуйте механізм виключень.
namespace _06_Exceptions_Classwork_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть число:");
            string input = Console.ReadLine();
            try
            {
                long number = long.Parse(input);
                int result = checked((int)number);
                Console.WriteLine($"Перетворене ціле число: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка перетворення");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Помилка: число виходить за межі типу int");
            }
        }
    }
}
