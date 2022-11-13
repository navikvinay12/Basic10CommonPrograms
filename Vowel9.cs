using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic10Programs
{
    internal class Vowel9
    {
        public static void CheckingVowel()
        {
            Console.WriteLine("enter any alphabet to check its vowel status");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine($"{ch} is of vowel type");
                    break;
                default:
                    Console.WriteLine($"{ch} is NOT of vowel type");
                    break;
            }
        }
    }
}
