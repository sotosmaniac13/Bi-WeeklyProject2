using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bi_Weekly_Project_2
{
    public class Calculator
    {
        public double calculator()
        {
            //User input and check for invalid input values
            double num1;
            double num2;

            while (true)
            {
                try
                {
                    Console.Write("\nEnter a number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    break;
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter another number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            
            Console.WriteLine("\nWhat calculation do you need? Enter the right symbol:\n" +
                "   + for Addition" + "      - for Subtraction" + "               * for Multiplication\n" +
                "   / for Division" + "      % for Remainder of Division" + "     square root for Square Root of the sum\n");

            
            double result = 0;
            bool validSymbol = true;
            while (validSymbol)
            {
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"-->Your result: {num1} + {num2} = " + (num1 + num2));
                        result = (num1 + num2);
                        validSymbol = false;
                        break;
                    case "-":
                        Console.WriteLine($"-->Your result: {num1} - {num2} = " + (num1 - num2));
                        result = (num1 - num2);
                        validSymbol = false;
                        break;
                    case "*":
                        Console.WriteLine($"-->Your result: {num1} * {num2} = " + (num1 * num2));
                        result = (num1 * num2);
                        validSymbol = false;
                        break;
                    case "/":
                        // Ask the user to enter a non-zero divisor until they do so
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"-->Your result: {num1} / {num2} = " + (num1 / num2));
                        result = (num1 / num2);
                        validSymbol = false;
                        break;
                    case "%":
                        while (num2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"-->Your result: {num1} % {num2} = " + (num1 % num2));
                        result = (num1 % num2);
                        validSymbol = false;
                        break;
                    case "square root":
                        Console.WriteLine($"-->The square root of {num1} + {num2} is " + Math.Sqrt(num1 + num2));
                        result = Convert.ToDouble(Math.Sqrt(num1 + num2));
                        validSymbol = false;
                        break;
                    // Return text for an incorrect option entry
                    default:
                        Console.WriteLine("That is an incorrect option entry, please enter one of the symbols above.");
                        break;
                }
            }
            return result;
        }
    }
}
