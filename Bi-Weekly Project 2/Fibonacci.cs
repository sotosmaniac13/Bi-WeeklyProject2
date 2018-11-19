using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bi_Weekly_Project_2
{
    class Fibonacci
    {
        
        public long FibonacciSequence(long result2)
        {
            //Conversion of double to long integer for the second result
            long result2_1 = Convert.ToInt64(result2);

            long firstnumber = 0;
            long secondnumber = 1;
            long result = 0;

            List<long> FibonacciList = new List<long>();

            
            //The first Fibonacci number
            if (result2_1 == 0)
            {
                FibonacciList.Add(result2_1);
            }

            //The second Fibonacci number
            if (result2_1 == 1)
            {
                FibonacciList.Add(0);
                Console.WriteLine("-->The 1st Fibonacci Number is 0.");
            }

            if (result2_1 == 2)
            {
                FibonacciList.Add(0);
                FibonacciList.Add(1);
                Console.WriteLine("-->The 2nd Fibonacci Number is 1.");
            }

            if (result2_1 == 3)
            {
                FibonacciList.Add(0);
                FibonacciList.Add(1);
                FibonacciList.Add(1);
                FibonacciList.Add(2);
                FibonacciList.Add(3);
                Console.WriteLine("-->The 3rd Fibonacci Number is 1.");
            }
            

            if (result2_1 > 3)
            {
                //Console.WriteLine("0\n1");
                for (int i = 2; i <= result2_1 - 1; i++)
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                    FibonacciList.Add(result);
                    //Console.WriteLine(result);
                }

                FibonacciList.Add(0);
                FibonacciList.Add(1);
                FibonacciList.Add(1);
                FibonacciList.Add(2);
                Console.WriteLine("-->The {0}th Fibonacci Number is {1}.", result2_1, result);
            }



            if (FibonacciList.Contains(result2_1) || result2_1 == 0 || result2_1 == 1)
            {
                Console.WriteLine("-->{0} is a Fibonacci Number.", result2_1);
            }
            else
                Console.WriteLine("-->{0} is not a Fibonacci Number.", result2_1);
            return result;
        }
    }
}
