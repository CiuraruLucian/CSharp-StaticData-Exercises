using System;
namespace StaticData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");

            SavingsAccount s1 = new SavingsAccount(50);

            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}",
            SavingsAccount.GetInterestRate());

            // Try to change the interest rate via property.
            SavingsAccount.SetInterestRate(0.08);

            // Make a second account.
            SavingsAccount s2 = new SavingsAccount(100);

            // Should print 0.08...right??
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.InterestRate);

            /*
            // Make new object, this does NOT ’reset’ the interest rate.
            SavingsAccount s3 = new SavingsAccount(10000.75);
            Console.WriteLine("Interest rate is {0}", SavingsAccount.GetInterestRate());


            // Print the current interest date rate.
            Console.WriteLine("Interest rate is {0}", SavingsAccount.GetInterestRate());
            */
            Console.ReadLine();
        }
    }
    class SavingsAccount
    {
        //Instance-level data.
        public double currBalance;

        //A static point of data.
        public static double currInterestRate = 0.04;

        // Notice that our constructor is setting
        // the static currInterestRate value.
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }


        // A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static ctor!");
            currInterestRate = 0.04;
        }

        // Static members to get/set interest rate.
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
        
        public static void SetInterestRate( double newRate )
        {
            currInterestRate = newRate;

        }
        // A static property
        public static double InterestRate
        {
            get { return currInterestRate; } 
            set { currInterestRate = value; }
        }
    }
}
