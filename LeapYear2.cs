using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class LeapYear2
    {
        public static void CheckingLeapYear()
        {
            Console.WriteLine("enter any year to check leap status");
            int leap = Convert.ToInt32(Console.ReadLine());
            if (leap % 4 == 0)
            {
                Console.WriteLine($"{leap} is a Leap Year!");
            }
            else
            {
                Console.WriteLine($"{leap} is NOT a Leap Year!");
            }
        }
    }
}
