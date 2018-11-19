using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bi_Weekly_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("-----Very Specific Calculator-----");
            Console.WriteLine("----------------------------------");
            
            //Calculation of the first result
            Calculator calculator1 = new Calculator();
            double result1 = calculator1.calculator();

            //Calculation of the seconnd result
            Calculator calculator2 = new Calculator();
            double result2 = calculator2.calculator();
            
            //Greatest Common Divider of the two results
            GreatestCommonDivisor newGCD = new GreatestCommonDivisor();
            int GCD = newGCD.GCDFinder(result1, result2);

            //Checking if the second result is a Prime Number
            Result2CheckIfPrime newResult2CheckIfPrime = new Result2CheckIfPrime();
            newResult2CheckIfPrime.CheckIfResult2IsPrime(result2);

            //Finding the corresponding Fibonacci Number based on the second result
            Fibonacci newFibonacci = new Fibonacci();
            newFibonacci.FibonacciSequence(Convert.ToInt64(result2));

            Console.WriteLine("\nPress Enter to exit the program...");
            Console.ReadLine();

        }
    }
}
