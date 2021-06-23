using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var columnNumber = 1;
        var expected = "A";
        Assert.Equal(expected, new Solution().ConvertToTitle(columnNumber));
    }

    [Fact]
    public void ExampleTest2()
    {
        var columnNumber = 28;
        var expected = "AB";
        Assert.Equal(expected, new Solution().ConvertToTitle(columnNumber));
    }

    [Fact]
    public void ExampleTest3()
    {
        var columnNumber = 701;
        var expected = "ZY";
        Assert.Equal(expected, new Solution().ConvertToTitle(columnNumber));
    }

    [Fact]
    public void ExampleTest4()
    {
        var columnNumber = 2147483647;
        var expected = "FXSHRXW";
        Assert.Equal(expected, new Solution().ConvertToTitle(columnNumber));
    }

    [Fact]
    public void ExampleTest5()
    {
        var columnNumber = 26;
        var expected = "Z";
        Assert.Equal(expected, new Solution().ConvertToTitle(columnNumber));
    }

    [Fact]
    public void ExampleTest6()
    {
        var columnNumber = 27;
        var expected = "AA";
        Assert.Equal(expected, new Solution().ConvertToTitle(columnNumber));
    }
}