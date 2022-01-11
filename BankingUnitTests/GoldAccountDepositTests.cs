using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingUnitTests;

public class GoldAccountDepositTests
{
    [Fact]
    public void GoldAccountsGetABonus()
    {
        // Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        account.Type = AccountType.Gold;

        // When
        account.Deposit(100M);
       
        // Then
        Assert.Equal(110M + openingBalance, account.GetBalance());
        
    }
}

