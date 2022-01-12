namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
        private ICalculateBonuses _bonusCalculator;
        private INotifyTheFeds _fedNotifier;

        public BankAccount(ICalculateBonuses bonusCalculator, INotifyTheFeds fedNotifier)
        {
            _bonusCalculator = bonusCalculator;
            _fedNotifier = fedNotifier;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit +
                _bonusCalculator.GetBonusForDeposit(_balance, amountToDeposit);
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            // "Guard" - don't do any work unless these preconditions are met.
            if(amountToWithdraw > _balance)
            {
                // Abnormally End.
                throw new OverdraftException();
            }
            _fedNotifier.NotifyOfWithdrawl(this, amountToWithdraw);
            _balance -= amountToWithdraw;
        }
    }
}