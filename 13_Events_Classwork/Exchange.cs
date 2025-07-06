namespace _13_Events_Classwork
{
    public delegate void RateChangedHandler(decimal newRate);    
    public delegate void MaxRateReachedHandler(decimal maxRate);    
    public delegate void MinRateReachedHandler(decimal minRate);
    internal class Exchange
    {
        private decimal _currentUsdtoUah;
        private decimal _maxRate = decimal.MinValue;
        private decimal _minRate = decimal.MaxValue;
        private Random _random = new Random();

        public event RateChangedHandler RateChanged;
        public event MaxRateReachedHandler MaxRateReached;
        public event MinRateReachedHandler MinRateReached;


        public void SimulateRateChange()
        {
            _currentUsdtoUah = Math.Round((decimal)(_random.NextDouble() * 5 + 40), 2);
            Console.WriteLine($"\n[Біржа] Новий курс USD/UAH: {_currentUsdtoUah} ₴");

            RateChanged?.Invoke(_currentUsdtoUah);

            if (_currentUsdtoUah > _maxRate)
            {
                _maxRate = _currentUsdtoUah;
                MaxRateReached?.Invoke(_currentUsdtoUah);
            }
            if (_currentUsdtoUah < _minRate)
            {
                _minRate = _currentUsdtoUah;
                MinRateReached?.Invoke(_currentUsdtoUah);
            }
        }
    }
}
