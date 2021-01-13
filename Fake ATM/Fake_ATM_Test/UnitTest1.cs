using System;
using Xunit;
using Fake_ATM;

namespace Fake_ATM_Test
{
    public class UnitTest1
    {
        [Fact]
        public void testViewBalance()
        {
            try
            {
                decimal originalBalance = Program.Balance;
                Assert.Equal(originalBalance, Program.ViewBalance());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [Theory]
        [InlineData(500.00)]
        [InlineData(600.00)]
        [InlineData(100.00)]
        [InlineData(50.00)]
        public void testWithdraw(decimal withdrawAmt)
        {
            decimal newBalance = Program.Balance - withdrawAmt;
            Assert.Equal(newBalance, Program.Withdraw(withdrawAmt));
        }

        [Theory]
        [InlineData(500.00)]
        [InlineData(600.00)]
        [InlineData(100.00)]
        [InlineData(50.00)]
        public void testDeposit(decimal depositAmt)
        {
            decimal newBalance = Program.Balance + depositAmt;
            Assert.Equal(newBalance, Program.Deposit(depositAmt));
        }
    }
}
