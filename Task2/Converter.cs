using System;
namespace Task2
{
    public class Converter
    {
        readonly double usd;
        readonly double eur;
        readonly double rub;

        public double Usd { get { return usd; } }
        public double Eur { get { return eur; } }
        public double Rub { get { return rub; } }

        public Converter()
        {
            usd = 28;
            eur = 34;
            rub = 75;
        }

        public Converter( double usd, double eur, double rub )
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double? ConvertToUAH( double amount, string currency )
        {
            if (currency == "USD")
            {
                double result = amount * usd;
                Console.WriteLine($"{amount} UAH = {result} USD");
                return result;
            }
            else if (currency == "EUR")
            {
                double result = amount * eur;
                Console.WriteLine($"{amount} UAH = {result} EUR");
                return result;
            }
            else if (currency == "RUB")
            {
                double result = amount * rub;
                Console.WriteLine($"{amount} UAH = {result} RUB");
                return result;
            }
            else
            {
                Console.WriteLine("Error: wrong currency");
                return null;
            }
        }

        public double? ConvertFromUAH( double amount, string currency )
        {
            if (currency == "USD")
            {
                double result = amount / usd;
                Console.WriteLine($"{amount} USD = {result} UAH");
                return result;
            }
            else if (currency == "EUR")
            {
                double result = amount / eur;
                Console.WriteLine($"{amount} EUR = {result} UAH");
                return result;
            }
            else if (currency == "RUB")
            {
                double result = amount / rub;
                Console.WriteLine($"{amount} RUB = {result} UAH");
                return result;
            }
            else
            {
                Console.WriteLine("Error: wrong currency");
                return null;
            }
        }
    }
}
