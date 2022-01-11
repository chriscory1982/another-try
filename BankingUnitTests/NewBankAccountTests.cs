using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingUnitTests
{
    public class NewBankAccountTests
    {
        [Fact]
        public void NewAccountHasTheCorrectOpeningBalance()
        {
            // Given
            var account = new BankAccount();
            decimal expectedOpeningBalance = 5000M;
            // When
            decimal balance = account.GetBalance();
            // Then
            Assert.Equal(expectedOpeningBalance, balance);
        }
    }
}
