using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class Harmonic4
    {
        public static void HarmonicNumber()
        {
            Console.WriteLine("Finding Harmonic value till Nth number");
            Console.WriteLine("Calculating Harmonic series so please provide Nth number");
            double num = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for (int i = 2; i <= num; i++)
            {
                result += (float)1 / i;
            }
            Console.WriteLine($"The Harmonic value obtained is : {result}");
        }
    }
}
