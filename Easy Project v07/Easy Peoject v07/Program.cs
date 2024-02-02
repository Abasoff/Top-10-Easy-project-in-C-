using System;

namespace TemperatureConverterApp
{
    class Program
    {
        //---------------------------------------------------------------------
        /* This project made by Anar Abasov
         * Temperature Converter (Celsius to Fahrenheit): Create a program that converts temperatures between Celsius and Fahrenheit.*/
        //---------------------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter App");

            while (true)
            {
                Console.WriteLine("Choose conversion:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Fahrenheit to Celsius");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertCelsiusToFahrenheit();
                        break;
                    case "2":
                        ConvertFahrenheitToCelsius();
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (1, 2, or 3).");
                        break;
                }

                Console.WriteLine("Do you want to perform another conversion? (Y/N): ");
                string continueOption = Console.ReadLine();
                if (continueOption.Trim().ToUpper() != "Y")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
            }
        }

        static void ConvertCelsiusToFahrenheit()
        {
            Console.Write("Enter the temperature in Celsius (°C): ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius}°C is equivalent to {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void ConvertFahrenheitToCelsius()
        {
            Console.Write("Enter the temperature in Fahrenheit (°F): ");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit}°F is equivalent to {celsius}°C");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
