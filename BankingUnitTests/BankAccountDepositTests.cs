using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingUnitTests;

public class BankAccountDepositTests
{
    [Fact]
    public void MakingADepositIncreasesTheBalance()
    {
        // Given
        var account = new BankAccount();
        decimal amountToDeposit = 100M;
        var openingBalance = account.GetBalance();
        // When
        account.Deposit(amountToDeposit);
        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}

