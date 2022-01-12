

namespace BankingUnitTests
{
    public class BankAccountWithdrawalTests
    {
        [Fact]
        public void WithdrawDecreasesTheBalance()
        {
            var account = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyTheFeds>().Object);
            decimal amountToWithdraw = 100M;
            var openingBalance = account.GetBalance();
            // When
            account.Withdraw(amountToWithdraw);
            // Then
            Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());

        }

        [Fact]
        public void CanWithdrawAllMoney()
        {
            var account = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyTheFeds>().Object);

            account.Withdraw(account.GetBalance());

            Assert.Equal(0, account.GetBalance());
        }

        [Fact]
        public void OverdraftNotAllowedThrowsAnException()
        {
            var account = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyTheFeds>().Object);

            Assert.Throws<OverdraftException>(
                // Anonymous Function implemented with a Lambda
                () => account.Withdraw(account.GetBalance() + .01M)
                );

            // Assert.Throws<OverdraftException>(DoOverdraft);

        }

        // "Named Function" "A Method Group"
        //public void DoOverdraft()
        //{
        //    var account = new BankAccount();
        //    account.Withdraw(account.GetBalance() + .01M);
        //}
    }
}
