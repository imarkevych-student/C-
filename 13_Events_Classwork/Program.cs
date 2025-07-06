//Завдання:
//Реалізувати на подійній моделі функціонал фінансової біржі.
//Створити клас «Біржа», який буде містити методи для імітації зміни курса та подію досягнення максиму або мінімуму курсу.
//Також є покупці-трейдери, які мають кількість своєї валюти та обробники зміни курсу і відповідоно до своїх цілей виконуватимуть роботу по продажу або купівлі грошей(акцій).
//Реалізацію генерації курсу розробляйте на власний розсуд (рандом).
namespace _13_Events_Classwork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Exchange exchange = new Exchange();

            Trader ivan = new Trader("Іван", 6000m, 41m, 44.5m);   
            Trader olena = new Trader("Олена", 8000m, 42.5m, 44m); 


            ivan.Subscribe(exchange);
            olena.Subscribe(exchange);

            exchange.MaxRateReached += rate => Console.WriteLine($"[Біржа] 📈 Новий максимум курсу: {rate} ₴/USD");
            exchange.MinRateReached += rate => Console.WriteLine($"[Біржа] 📉 Новий мінімум курсу: {rate} ₴/USD");

            for (int i = 0; i < 5; i++)
            {
                exchange.SimulateRateChange();
                Thread.Sleep(1000);
            }
        }
    }
}
