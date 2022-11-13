using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class LargestOfThreeNumbers10
    {
        public static void LargestOfThreeNumbers()
        {
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is the greatest number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is the greatest number");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"{num3} is the greatest number");
            }
            else
            {
                Console.WriteLine("All the numbers are equal.");
            }
        }
    }
}
