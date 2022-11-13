using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class SwappingTwoNumbers7
    {
        public static void SwapNumber()
        {
            Console.WriteLine("enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swapping {num1} and {num2} ");
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"After Swapping  {num1} and {num2} ");
        }
    }
}
