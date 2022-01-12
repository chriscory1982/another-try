

namespace BankingUnitTests
{
    public class DummyBonusCalculator : ICalculateBonuses
    {
        public decimal GetBonusForDeposit(decimal balance, decimal amountToDeposit)
        {
            return 0;
        }
    }
}
