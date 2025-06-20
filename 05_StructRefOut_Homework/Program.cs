//Створіть клас Calculator.
//У класі реалізувати чотири методи для арифметичних дій:
//-Add – додавання
//- Sub – віднімання
//- Mul – множення
//- Div - ділення.
//Метод ділення повинен робити перевірку ділення на нуль, якщо перевірка не проходить, згенерувати виключення.
//Користувач вводить значення, над якими хоче зробити операцію і вибирає саму операцію. При виникненні помилок повинні генеруватися виключення.

namespace _05_StructRefOut_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Calculator calc = new Calculator();

            try
            {
                Console.Write("Введіть перше число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Оберіть операцію (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calc.Add(num1, num2);
                        break;
                    case "-":
                        result = calc.Sub(num1, num2);
                        break;
                    case "*":
                        result = calc.Mul(num1, num2);
                        break;
                    case "/":
                        result = calc.Div(num1, num2);
                        break;
                    default:
                        throw new InvalidOperationException("Невідома операція.");
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введене значення не є числом.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Виникла помилка: {ex.Message}");
            }

        }
    }
}
