using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class BasePowerValue3
    {
        public static void PowerValue()
        {
            Console.WriteLine("enter any integer number so that we will set it as power of 2 and will be showing the result of same");
            int baseNumber = 2;
            int powerInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < powerInput; i++)
            {
                baseNumber = baseNumber * 2;
            }
            Console.WriteLine(baseNumber);
        }
    }
}
