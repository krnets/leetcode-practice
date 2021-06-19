using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var numBottles = 9;
        var numExchange = 3;
        var expected = 13;
        Assert.Equal(expected, new Solution().NumWaterBottles(numBottles, numExchange));
    }

    [Fact]
    public void ExampleTest2()
    {
        var numBottles = 15;
        var numExchange = 4;
        var expected = 19;
        Assert.Equal(expected, new Solution().NumWaterBottles(numBottles, numExchange));
    }

    [Fact]
    public void ExampleTest3()
    {
        var numBottles = 5;
        var numExchange = 5;
        var expected = 6;
        Assert.Equal(expected, new Solution().NumWaterBottles(numBottles, numExchange));
    }

    [Fact]
    public void ExampleTest4()
    {
        var numBottles = 2;
        var numExchange = 3;
        var expected = 2;
        Assert.Equal(expected, new Solution().NumWaterBottles(numBottles, numExchange));
    }
}