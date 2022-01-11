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
        var account = new GoldAccount();
        var openingBalance = account.GetBalance();

        account.Deposit(100M);

        Assert.Equal(openingBalance + 110M, account.GetBalance());
    }
}

