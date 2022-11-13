namespace Basic10Programs
{
    internal class SimplePrograms
    {
        public static void Welcome()
        {
            Console.WriteLine("WELCOME!\n" +
                "Press 1  : Flip Coin and print percentage of Heads and Tails\n"+
                "Press 2  : Leap Year\n" +
                "Press 3  : Power of 2\n" +
                "Press 4  : Harmonic Number\n" +
                "Press 5  : Prime Factorization\n" +
                "Press 6  : Quotient and Remainder\n" +
                "Press 7  : Swap Two Numbers\n");
        }
        public static void Main(string[] args)
        {
            Welcome();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    HeadTailPercentage1.HeadVsTail();
                    break;
                case 2:
                    LeapYear2.CheckingLeapYear();
                    break;
                case 3:
                    BasePowerValue3.PowerValue();
                    break;
                case 4:
                    Harmonic4.HarmonicNumber();
                    break;
                case 5:
                    PrimeFactorization5.PrimeFactors();
                    break;
                case 6:
                    QuotientRemainder6.FindingQuotientRemainder();
                    break;
                case 7:
                    SwappingTwoNumbers7.SwapNumber();
                    break;
                default :
                    Console.WriteLine("Please enter input in range 1-10 only");
                    break;
            }
        }
    }
}
