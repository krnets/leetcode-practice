using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var columnTitle = "A";
        var expected = 1;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }

    [Fact]
    public void ExampleTest2()
    {
        var columnTitle = "AB";
        var expected = 28;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }

    [Fact]
    public void ExampleTest3()
    {
        var columnTitle = "ZY";
        var expected = 701;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }

    [Fact]
    public void ExampleTest4()
    {
        var columnTitle = "FXSHRXW";
        var expected = 2147483647;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }

    [Fact]
    public void ExampleTest5()
    {
        var columnTitle = "Z";
        var expected = 26;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }

    [Fact]
    public void ExampleTest6()
    {
        var columnTitle = "AA";
        var expected = 27;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }

    [Fact]
    public void ExampleTest7()
    {
        var columnTitle = "AAA";
        var expected = 703;
        Assert.Equal(expected, new Solution().TitleToNumber(columnTitle));
    }
}