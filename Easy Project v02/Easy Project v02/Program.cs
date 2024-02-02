using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Project_v02
{
    //---------------------------------------------------------------------------------
    /* This project made by Anar Abasov
     * Unit Converter (e.g., Length, Weight, Volume): Build a program that converts units, such as inches to centimeters, pounds to kilograms, or liters to gallons. */
    //---------------------------------------------------------------------------------

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Unit Converter (e.g., Length, Weight, Volume)");
            Console.WriteLine("----------------------------");

            do
            {
                Console.WriteLine("Select a category; ");
                Console.WriteLine("\t1. Length");
                Console.WriteLine("\t2. Weight");
                Console.WriteLine("\t3. Volume");

                Console.Write("Select a category: ");
                int category = int.Parse(Console.ReadLine());

                switch (category)
                {
                    case 1:
                        lengthConvertor();
                        break;
                    case 2:
                        weightConvertor();
                        break;
                    case 3:
                        volumeConvertor();
                        break;
                    default:
                        Console.WriteLine("Invalid category choice.");
                        break;
                }

                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }



        static void lengthConvertor()
        {
            int meters = 100;
            double inch = 39.3701;
            double feet = 3.28084;
            double result = 0;

            Console.WriteLine("Length Converter");
            Console.WriteLine("------------------------");
            Console.WriteLine("Choose conversion");
            Console.WriteLine("\t1. Meters to Feet");
            Console.WriteLine("\t2. Meters to Inches");
            Console.WriteLine("\t3. Meters to Centimeters");
            Console.WriteLine("\t4. Feet to Meters");
            Console.WriteLine("\t5. Inches to Meters");
            Console.WriteLine("\t6. Centimeters to Meters");

            Console.Write("Enter an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the Meters: ");
                    double meters_ = Double.Parse(Console.ReadLine());
                    result = meters * feet;
                    Console.WriteLine($"{meters} meters = {result} feet");
                    break;

                case "2":
                    Console.WriteLine("Enter the Meters: ");
                    double metersToInches = Double.Parse(Console.ReadLine());
                    result = metersToInches * inch;
                    Console.WriteLine($"{metersToInches} meters = {result} inches");
                    break;

                case "3":
                    Console.WriteLine("Enter the Meters: ");
                    double metersToCentimeters= Double.Parse(Console.ReadLine());
                    result = metersToCentimeters * meters;
                    Console.WriteLine($"{metersToCentimeters} meters = {result} centimetrs");
                    break;

                case "4":
                    Console.WriteLine("Enter the Feets: ");
                    double feetToMeters= Double.Parse(Console.ReadLine());
                    result = feetToMeters / feet;
                    Console.WriteLine($"{feetToMeters} meters = {result} meters");
                    break;

                case "5":
                    Console.WriteLine("Enter the Inches: ");
                    double inchesToMetres = Double.Parse(Console.ReadLine());
                    result = inchesToMetres / inch;
                    Console.WriteLine($"{inchesToMetres} meters = {result} meters");
                    break;

                case "6":
                    Console.WriteLine("Enter the Centimeters: ");
                    double centimetersToMeters= Double.Parse(Console.ReadLine());
                    result = centimetersToMeters / meters;
                    Console.WriteLine($"{centimetersToMeters} meters = {result} meters");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        static void weightConvertor()
        {
            double pounds = 2.20462;
            double result = 0;

            Console.WriteLine("Weight Converter");
            Console.WriteLine("------------------------");
            Console.WriteLine("Choose conversion");
            Console.WriteLine("\t1. Kilograms to Pounds");
            Console.WriteLine("\t2. Pounds to Kilograms");

            Console.Write("Enter an option: ");

            string choice = Console.ReadLine();

            switch(choice) 
            {
                case "1":
                    Console.WriteLine("Enter the Kilograms : ");
                    double kilograms= Double.Parse(Console.ReadLine());
                    result = kilograms * pounds;
                    Console.WriteLine($"{kilograms} kg= {result} pounds");
                    break;

                case "2":
                    Console.WriteLine("Enter the Pounds: ");
                    double poundsToKilograms = Double.Parse(Console.ReadLine());
                    result = poundsToKilograms  / pounds;
                    Console.WriteLine($"{poundsToKilograms} pound = {result} kg");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        static void volumeConvertor()
        {
            double result = 0;
            double gallon = 0.264172;
            int millitres = 1000;

            Console.WriteLine("Volpume Converter");
            Console.WriteLine("------------------------");
            Console.WriteLine("Choose conversion");
            Console.WriteLine("\t1. Liters to Gallons");
            Console.WriteLine("\t2. Gallons (US) to Liters");
            Console.WriteLine("\t3. Liters to Milliliters");
            Console.WriteLine("\t4. Milliliters to Liters");

            Console.Write("Enter an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the Liters : ");
                    double litr = Double.Parse(Console.ReadLine());
                    result = litr * gallon;
                    Console.WriteLine($"{litr} lt = {result} gallon");
                    break;

                case "2":
                    Console.WriteLine("Enter the Gallon: ");
                    double gallonToLitres= Double.Parse(Console.ReadLine());
                    result = gallonToLitres / gallon;
                    Console.WriteLine($"{gallonToLitres} gallon = {result} lt");
                    break;
                case "3":
                    Console.WriteLine("Enter the Liters: ");
                    double litersToMililiters= Double.Parse(Console.ReadLine());
                    result = litersToMililiters * millitres;
                    Console.WriteLine($"{litersToMililiters} lt = {result} mililiters");
                    break;

                case "4":
                    Console.WriteLine("Enter the Mililitres: ");
                    double mililitresToLiters= Double.Parse(Console.ReadLine());
                    result = mililitresToLiters / millitres;
                    Console.WriteLine($"{mililitresToLiters} mililitres = {result} lt");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
