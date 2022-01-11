namespace BankingDomain
{
    // Enumerated Constants - a "list of acceptable values for a variable"
    public enum AccountType { Standard, Gold};
    public class BankAccount
    {
        private decimal _balance = 5000;

        public AccountType Type { get; set; } = AccountType.Standard;
       
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            decimal bonus = 0;
     
            if(Type == AccountType.Gold)
            {
                bonus = amountToDeposit * .10M;
            }
            _balance += amountToDeposit + bonus;
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