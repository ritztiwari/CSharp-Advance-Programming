using System.Reflection;
using CSharp_Advance_Programming.NUnit.TestingBankTransactions;

public class TestingBankTransactionsTest
{
    private Bank _account;

    [SetUp]
    public void Setup()
    {
        _account = new Bank();
    }

    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        _account.Deposit(1000);

        Assert.AreEqual(1000, _account.GetBalance());
    }

    [Test]
    public void MultipleDeposits_ShouldAccumulateBalance()
    {
        _account.Deposit(500);
        _account.Deposit(300);

        Assert.AreEqual(800, _account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldReduceBalance()
    {
        _account.Deposit(1000);
        _account.Withdrawl(400);

        Assert.AreEqual(600, _account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldFail()
    {
        _account.Deposit(500);

        Assert.Throws<InvalidOperationException>(
            () => _account.Withdrawl(800)
        );
    }
}
