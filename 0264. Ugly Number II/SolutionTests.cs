using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = 10;
        var expected = 12;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = 1;
        var expected = 1;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = 7;
        var expected = 8;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = 10;
        var expected = 12;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest5()
    {
        var input = 15;
        var expected = 24;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest6()
    {
        var input = 150;
        var expected = 5832;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest7()
    {
        var input = 9;
        var expected = 10;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }

    [Fact]
    public void ExampleTest8()
    {
        var input = 1352;
        var expected = 402653184;
        Assert.Equal(expected, new Solution().NthUglyNumber(input));
    }
}