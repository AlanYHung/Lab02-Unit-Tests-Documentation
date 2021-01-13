using System;

namespace Fake_ATM
{
    public class Program
    {
        public static decimal Balance = (decimal)500.00;
        public static void Main(string[] args)
        {
            string userInput;
            string withdrawAmount;
            string depositAmount;

            do
            {
                Console.Clear();
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                userInput = Console.ReadLine();
                Console.Clear();

                switch(userInput)
                {
                    case "1":
                        Console.Write("Your current balance is: ");
                        Balance = ViewBalance();
                        break;
                    case "2":
                        Console.WriteLine("How much would you like to withdraw?");
                        withdrawAmount = Console.ReadLine();
                        Balance = Withdraw(Convert.ToDecimal(withdrawAmount));
                        break;
                    case "3":
                        Console.WriteLine("How much would you like to Deposit?");
                        depositAmount = Console.ReadLine();
                        Balance = Deposit(Convert.ToDecimal(depositAmount));
                        break;
                    default:
                        Console.WriteLine("Invalid Input.  Please choose a value between 1-4.");
                        break;
                }
            } while (userInput != "4");
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static decimal Withdraw(decimal withdrawAmt)
        {
            decimal newWBalance = Balance;

            if (withdrawAmt > 0)
            {
                if(newWBalance - withdrawAmt > 0)
                {
                    newWBalance = Balance - withdrawAmt;
                }
                else
                {
                    Console.WriteLine("Unable to withdraw.  Insufficient Balance.");
                }
            }
            else
            {
                Console.WriteLine("Unable to withdraw a negative amount.");
            }

            return newWBalance;
        }

        public static decimal Deposit(decimal depositAmt)
        {
            decimal newDBalance = Balance;

            if (depositAmt > 0)
            {
                newDBalance = Balance + depositAmt;
            }
            else
            {
                Console.WriteLine("Unable to deposit a negative amount.");
            }

            return newDBalance;
        }
    }
}
