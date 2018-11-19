using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bi_Weekly_Project_2
{
    class GreatestCommonDivisor : IEnumerable
    {
        public int GCDFinder(double result1, double result2)
        {
            //First list contains the divisors of the first result.
            //Second list contains the divisors of the second result.
            //Third list contains the common divisors of the two lists above.
            List<int> result1List = new List<int>();
            List<int> result2List = new List<int>();
            List<int> commonDivisorsList = new List<int>();

            //Conversion of doubles to integers
            int result1_1 = Convert.ToInt32(result1);
            int result2_1 = Convert.ToInt32(result2);
            string saveResult1 = Convert.ToString(result1_1);
            string saveResult2 = Convert.ToString(result2_1);

            if (result1_1 != 0 && result2_1 != 0)
            {
                //Conversion of negative numbers to positive
                if (result1_1 < 0)
                {
                    result1_1 = -result1_1;
                }

                if (result2_1 < 0)
                {
                    result2_1 = -result2_1;
                }

                //Finding divisors of the first result and adding them to a list.
                for (int i = 1; i <= result1_1; i++)
                {
                    if (result1_1 % i == 0)
                    {
                        result1List.Add(i);
                    }
                }

                //Finding divisors of the second result and adding them to a second list.
                for (int i = 1; i <= result2_1; i++)
                {
                    if (result2_1 % i == 0)
                    {
                        result2List.Add(i);
                    }
                }

                //Comparing the two lists and searching for common divisors, then adding them to a third list.
                foreach (int number in result2List)
                {
                    if (result1List.Contains(number))
                    {
                        commonDivisorsList.Add(number);
                    }
                }

                //Display of the two calculated results and their GCD.
                //Console.WriteLine("\n-->The Greatest Common Divisor for {0} and {1} is {2}.", result1_1 , result2_1, commonDivisorsList.Max());
                Console.WriteLine("\n-->The Greatest Common Divisor for " + saveResult1 + " and " + saveResult2 + " is {0}.", commonDivisorsList.Max());
                return commonDivisorsList.Max();


            }
            else
                Console.WriteLine("\n-->There are no Common Divisors between the first and the second result.");
                return 0;
           
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
