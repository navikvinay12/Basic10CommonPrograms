using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class PrimeFactorization5
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Prime Factorization Program! \nPlease enter any number to find Prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int div = 2; div * div <= num; div++)
            {
                while (num % div == 0)
                {
                    num = num / div;
                    Console.Write(div + " ");
                }
            }
            if (num != 1)
            {
                Console.Write(num);
            }
        }
    }
}
