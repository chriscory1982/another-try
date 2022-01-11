namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _balance = 5000;
       
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            // "Guard" - don't do any work unless these preconditions are met.
            if(amountToWithdraw > _balance)
            {
                // Abnormally End.
                throw new OverdraftException();
            }

            _balance -= amountToWithdraw;
        }
    }
}