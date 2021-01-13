using System;

namespace Fake_ATM
{
    public class Program
    {
        public static decimal Balance = (decimal)0.00;
        public static void Main(string[] args)
        {
            string userInput;

            do
            {
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                userInput = Console.ReadLine();
            } while (userInput != "4");
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal withdrawAmt)
        {
            decimal newWBalance = Balance;

            return newWBalance;
        }

        public static decimal Deposit(decimal depositAmt)
        {
            decimal newDBalance = Balance;

            return newDBalance;
        }
    }
}
