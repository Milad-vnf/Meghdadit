using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main()
        {
            string[] availableCurrency = CurrencyConverter.GetCurrencyTags();

            Console.WriteLine("Available Currencies");
            Console.WriteLine(string.Join(",", availableCurrency));
            Console.WriteLine("\n");

            Console.WriteLine("Insert Currency you want to convert FROM");
            string fromCurrency = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("Insert Currency you want to convert TO");
            string toCurrency = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("How much "+ fromCurrency +" do you have?");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            float exchangeRate = CurrencyConverter.GetExchangeRate(fromCurrency, toCurrency, amount);
            Console.WriteLine( "FROM " + amount + " " + fromCurrency.ToUpper() + " TO " + toCurrency.ToUpper() + " = " + exchangeRate);
            
            Console.ReadLine();
        }
    }
}