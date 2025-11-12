namespace AtmServices.Test;

using AtmServices;

public class AtmTests

{

    Atm testAtm;

    int initialBalance = 100;

    public AtmTests() {

        testAtm = new Atm(initialBalance);

    }


    [Fact]

    public void Test_Withdraw()

    {

        var result = testAtm.withdraw(25);

        Assert.True(result);

        Assert.Equal(75, testAtm.getBalance());

    }

    [Fact]

    public void Test_Withdraw_Failure_Insufficient_Funds()

    {

        var result = testAtm.withdraw(200);

        Assert.False(result);

        Assert.Equal(100, testAtm.getBalance());

    }

    [Fact]

    public void Test_Deposit()

    {

        var result = testAtm.deposit(200);

        Assert.True(result);

        Assert.Equal(300, testAtm.getBalance());

    }

    [Fact]

    public void Test_Deposit_Failure_Less_Than_Minimum_Required()

    {

        var result = testAtm.deposit(-100);

        Assert.False(result);

        Assert.Equal(100, testAtm.getBalance());

    }

}