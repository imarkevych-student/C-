namespace _13_Events_Classwork
{
    internal class Trader
    {
        public string Name { get; }
        public decimal HryvniaBalance   { get; private set; }
        public decimal DollarBalance { get; private set; }
        public decimal BuyUsdBelow { get; }
        public decimal SellUsdAbove { get; }

        public Trader(string name, decimal hryvnia, decimal buyUsdBelow, decimal sellUsdAbove)
        {
            Name = name;
            HryvniaBalance = hryvnia;            
            BuyUsdBelow = buyUsdBelow;
            SellUsdAbove = sellUsdAbove;
        }

        public void Subscribe(Exchange exchange)
        {
            exchange.RateChanged += OnRateChanged;            
        }

        private void OnRateChanged(decimal usdToUah)
        {
            if (usdToUah <= BuyUsdBelow && HryvniaBalance >= usdToUah)
            {
                int dollarsToBuy = (int)(HryvniaBalance / usdToUah);
                decimal totalCost = dollarsToBuy * usdToUah;

                DollarBalance += dollarsToBuy;
                HryvniaBalance -= totalCost;

                Console.WriteLine($"[{Name}] Купив ${dollarsToBuy} за {usdToUah} ₴/USD. Баланс: {HryvniaBalance:F2} ₴, {DollarBalance} $");
            }
            else if(usdToUah >= SellUsdAbove && DollarBalance >=1)
            {                
                decimal totalRevenue = DollarBalance * usdToUah;
                Console.WriteLine($"[{Name}] Продав ${DollarBalance} за {usdToUah} ₴/USD. Баланс: {HryvniaBalance + totalRevenue:F2} ₴, 0 $");

                HryvniaBalance += totalRevenue;
                DollarBalance = 0;
            }
            else
            {
                Console.WriteLine($"[{Name}] Немає можливості купити або продати. Поточний курс: {usdToUah} ₴/$");

            }
        }
    }
}
