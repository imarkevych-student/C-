//Завдання 2
//Створіть клас «Кредитна картка». Вам необхідно зберігати інформацію про номер картки, ПІБ власника, CVC, дату завершення роботи картки і т.д. Передбачити механізми ініціалізації полів класу. Якщо значення для ініціалізації неправильне, генеруйте виняток.
namespace _06_Exceptions_Classwork_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.Write("Введіть номер картки (16 цифр):");
                string cardNumber = Console.ReadLine();
                Console.Write("Введіть ПІБ власника:");
                string name = Console.ReadLine();
                Console.Write("Введіть СVC (3 цифри):");
                string cvc = Console.ReadLine();
                Console.Write("Введіть дату завершення дії картки (рік-місяць, напр. 2026-08): ");
                string dateInput = Console.ReadLine();
                DateTime expirationDate = DateTime.ParseExact(dateInput + "-01", "yyyy-MM-dd", null);

                CreditCard card = new CreditCard(cardNumber, name, cvc, expirationDate);

                Console.WriteLine("\nКартка успішно створена!");
                Console.WriteLine(card);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Помилка:" + ex.Message);
            }
        }

    }
}
