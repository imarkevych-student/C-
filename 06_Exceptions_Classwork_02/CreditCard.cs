using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Exceptions_Classwork_02
{
    internal class CreditCard
    {
        private string _cardNumber;
        private string _cardholderName;
        private string _cvc;
        private DateTime _expirationDate;

        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (value.Length != 16 || !IsDigitsOnly(value))
                {
                    throw new ArgumentException("Номер картки має складатаися з 16 цифр");
                }
                _cardNumber = value;
            }
        }
        public string CardholderName
        {
            get { return _cardholderName; }

            set
            {
                if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Ім'я не може бути порожнім."); }
                foreach (char c in value)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        throw new ArgumentException("Ім'я має містити літери та пробіли");
                    }
                }
                _cardholderName = value;
            }


        }
        public string CVC
        {
            get { return _cvc; }
            set
            {
                if (value.Length != 3 || !IsDigitsOnly(value))
                {
                    throw new ArgumentException("CVC має складатись з 3 цифр");
                }
                _cvc = value;
            }
        }

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                if (value <= DateTime.Now) { throw new ArgumentException("Термін дії картки минув"); }
                _expirationDate = value;
            }
        }

        public CreditCard(string cardNumber, string cardholderName, string cvc, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            CardholderName = cardholderName;
            CVC = cvc;
            ExpirationDate = expirationDate;
        }
        private bool IsDigitsOnly(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c)) return false;
            }
            return true;
        }

        public override string ToString()
        {
            return "Картка: **** **** **** " + CardNumber.Substring(12)
             + " | Власник: " + CardholderName
             + " | Дійсна до: " + ExpirationDate.ToString("MM/yyyy");
        }
    }
}



