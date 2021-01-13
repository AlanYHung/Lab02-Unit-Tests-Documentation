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
            string moreTransactions = "y";

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to C# ATM Solutions.  What would you like to do today?\n");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                userInput = Console.ReadLine();
                Console.Clear();

                switch(userInput)
                {
                    case "1":
                        Balance = ViewBalance();
                        Console.Write("Your current balance is: " + Balance);
                        Console.Write("\n\nPlease press ENTER to continue...");
                        Console.ReadKey();
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
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid Input.  Please choose a value between 1-4.");
                        Console.Write("\n\nPlease press ENTER to continue...");
                        Console.ReadKey();
                        break;
                }

                if(userInput != "4")
                {
                    Console.Clear();
                    Console.WriteLine("Would you like to make another transaction? (y/n)");
                    moreTransactions = Console.ReadLine();
                }

                if((userInput == "4") || (moreTransactions == "n") || (moreTransactions == "N"))
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using our ATM.  Have a nice day.");
                }
            } while ((userInput != "4") && (moreTransactions != "n") && (moreTransactions != "N"));
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
                if(newWBalance - withdrawAmt >= 0)
                {
                    newWBalance = Balance - withdrawAmt;
                }
                else
                {
                    Console.WriteLine("Unable to withdraw.  Insufficient Balance.");
                    Console.Write("\n\nPlease press ENTER to continue...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Unable to withdraw a negative or zero amount.");
                Console.Write("\n\nPlease press ENTER to continue...");
                Console.ReadKey();
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
                Console.Write("\n\nPlease press ENTER to continue...");
                Console.ReadKey();
            }

            return newDBalance;
        }
    }
}
