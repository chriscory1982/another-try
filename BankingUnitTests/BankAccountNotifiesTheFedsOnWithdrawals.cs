using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingUnitTests
{
    public class BankAccountNotifiesTheFedsOnWithdrawals
    {
        
        [Fact]
        public void test()
        {
            var mockFedNotifier = new Mock<INotifyTheFeds>();
            var account = new BankAccount(new Mock<ICalculateBonuses>().Object, mockFedNotifier.Object);

            account.Withdraw(100M);

            mockFedNotifier.Verify(m => m.NotifyOfWithdrawl(account, 100M), Times.Once);
        }
        



    }
}
