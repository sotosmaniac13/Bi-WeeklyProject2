using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bi_Weekly_Project_2
{
    class Result2CheckIfPrime
    {
        public void CheckIfResult2IsPrime(double result2)
        {
            //Conversion of double to integer for the second result
            int result2_1 = Convert.ToInt32(result2);


            //If the second result equals to 1 or 2, it is not a Prime Number.
            if (result2_1 == 0 || result2_1 == 1)
            {
                Console.WriteLine("-->" + result2_1 + " is not a Prime Number.");
                return;
            }

            //If the second result is smaller than 0, it is not a Prime Number.
            if (result2_1 < 0)
            {
                Console.WriteLine("-->" + result2_1 + " is not a Prime Number because Prime Numbers are only positive.");
                return;
            }

            else
            {
                for (int i = 2; i < result2_1; i++)
                {
                    if (result2_1 % i == 0)
                    {
                        Console.WriteLine("-->" + result2_1 + " is not a Prime Number.");
                        return;
                    }
                }

                Console.WriteLine("-->" + result2_1 + " is a Prime Number.");
            }
        }
    }
}
