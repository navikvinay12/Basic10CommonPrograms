namespace Basic10Programs
{
    internal class SimplePrograms
    {
        public static void Welcome()
        {
            Console.WriteLine("WELCOME!\n" +
                "Press 1  : Flip Coin and print percentage of Heads and Tails\n" );
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
                default :
                    Console.WriteLine("Please enter input in ragne 1-10 only");
                    break;
            }
        }
    }
}
