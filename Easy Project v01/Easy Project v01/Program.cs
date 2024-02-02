using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Project_v01
{
    //----------------------------------------------------------
    /* This project made by Anar Abasov 
     * Basic Calculator: Create a simple console-based calculator that allows users to perform basic arithmetic operations. */
    //----------------------------------------------------------

    internal class Program
    {
        static void Main(string[] args)
        {
            do { 
            double n1=0, n2=0;
            double result=0;

            Console.Write("Enter the first number: ");
            n1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose your arithmetic operations ");
            Console.WriteLine("\t+ Addition");
            Console.WriteLine("\t- Subtraction");
            Console.WriteLine("\t* Multiply");
            Console.WriteLine("\t/ Devide");

            Console.Write("Enter your Choose: ");


            switch (Console.ReadLine())
            {
                    case "+":
                        result = n1 + n2;
                        Console.WriteLine($"Your result: {n1} + {n2} = {result}");
                        break;
                    case "-":
                        result = n1 - n2;
                        Console.WriteLine($"Your result: {n1} - {n2} = {result}");
                        break;
                    case "*":
                        result = n1 * n2;
                        Console.WriteLine($"Your result: {n1} * {n2} = {result}");
                        break;
                    case "/":
                        result = n1 / n2;
                        Console.WriteLine($"Your result: {n1} / {n2} = {result}");
                        break;

                    default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.Write("Would you like to continue? (Y = yes, N = No): ");
        } while (Console.ReadLine().ToUpper() == "Y");


            Console.WriteLine("Thanks for using");
            Console.ReadKey();
        }
    }
}
