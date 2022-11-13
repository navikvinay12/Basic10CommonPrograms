using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class QuotientRemainder6
    {
        public static void FindingQuotientRemainder()
        {
            Console.WriteLine("enter the 1st number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double quotient = 0, remainder = 0;
            quotient = num1 / num2;
            remainder = num1 % num2;
            Console.WriteLine($"{num1}/{num2} ,Quotient is : {quotient} ");
            Console.WriteLine($"{num1}%{num2} ,Remainder is : {remainder} ");
        }
    }
}
