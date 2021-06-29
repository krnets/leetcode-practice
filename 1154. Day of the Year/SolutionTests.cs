using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var date = "2019-01-09";
        var expected = 9;
        Assert.Equal(expected, new Solution().DayOfYear(date));
    }

    [Fact]
    public void ExampleTest2()
    {
        var date = "2019-02-10";
        var expected = 41;
        Assert.Equal(expected, new Solution().DayOfYear(date));
    }

    [Fact]
    public void ExampleTest3()
    {
        var date = "2003-03-01";
        var expected = 60;
        Assert.Equal(expected, new Solution().DayOfYear(date));
    }

    [Fact]
    public void ExampleTest4()
    {
        var date = "2004-03-01";
        var expected = 61;
        Assert.Equal(expected, new Solution().DayOfYear(date));
    }

    [Fact]
    public void ExampleTest5()
    {
        var date = "1992-09-14";
        var expected = 258;
        Assert.Equal(expected, new Solution().DayOfYear(date));
    }
}