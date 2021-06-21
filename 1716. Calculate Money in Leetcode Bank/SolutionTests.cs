using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int n = 4;
        int expected = 10;
        Assert.Equal(expected, new Solution().TotalMoney(n));
    }

    [Fact]
    public void ExampleTest2()
    {
        int n = 10;
        int expected = 37;
        Assert.Equal(expected, new Solution().TotalMoney(n));
    }

    [Fact]
    public void ExampleTest3()
    {
        int n = 20;
        int expected = 96;
        Assert.Equal(expected, new Solution().TotalMoney(n));
    }
}