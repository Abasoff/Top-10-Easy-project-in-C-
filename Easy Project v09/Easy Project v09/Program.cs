using System;
using System.Collections.Generic;

class CurrencyConverter
{
    //------------------------------------------------
    /* This project made by Anar Abasov 
     * Currency Converter: Develop a program that converts currencies based on exchange rates.*/
    //------------------------------------------------

    static Dictionary<string, double> exchangeRates = new Dictionary<string, double>
    {
        { "USD", 1.0 },
        { "EUR", 0.85 },
        { "GBP", 0.73 },
        { "JPY", 110.14 },
        // Add more exchange rates here
    };

    static void Main()
    {
        Console.WriteLine("Welcome to the Currency Converter!");
        DisplayAvailableCurrencies();

        while (true)
        {
            Console.Write("\nEnter the source currency (e.g., USD): ");
            string fromCurrency = Console.ReadLine().ToUpper();

            if (!exchangeRates.ContainsKey(fromCurrency))
            {
                Console.WriteLine("Invalid currency code. Please choose from the available currencies.");
                continue;
            }

            Console.Write("Enter the target currency (e.g., EUR): ");
            string toCurrency = Console.ReadLine().ToUpper();

            if (!exchangeRates.ContainsKey(toCurrency))
            {
                Console.WriteLine("Invalid currency code. Please choose from the available currencies.");
                continue;
            }

            Console.Write("Enter the amount to convert: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric amount.");
                continue;
            }

            double convertedAmount = ConvertCurrency(fromCurrency, toCurrency, amount);

            Console.WriteLine($"{amount} {fromCurrency} is equal to {convertedAmount} {toCurrency}");

            Console.Write("Do you want to perform another conversion? (yes/no): ");
            string anotherConversion = Console.ReadLine().ToLower();
            if (anotherConversion != "yes")
            {
                break;
            }
        }
        Console.ReadKey();
    }

    static void DisplayAvailableCurrencies()
    {
        Console.WriteLine("Available currencies:");
        foreach (string currency in exchangeRates.Keys)
        {
            Console.WriteLine(currency);
        }
    }

    static double ConvertCurrency(string fromCurrency, string toCurrency, double amount)
    {
        double fromRate = exchangeRates[fromCurrency];
        double toRate = exchangeRates[toCurrency];
        return amount * (toRate / fromRate);
    }
}
