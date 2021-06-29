using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var num = 28;
        Assert.True(new Solution().CheckPerfectNumber(num));
    }

    [Fact]
    public void ExampleTest2()
    {
        var num = 6;
        Assert.True(new Solution().CheckPerfectNumber(num));
    }

    [Fact]
    public void ExampleTest3()
    {
        var num = 496;
        Assert.True(new Solution().CheckPerfectNumber(num));
    }

    [Fact]
    public void ExampleTest4()
    {
        var num = 8128;
        Assert.True(new Solution().CheckPerfectNumber(num));
    }

    [Fact]
    public void ExampleTest5()
    {
        var num = 2;
        Assert.False(new Solution().CheckPerfectNumber(num));
    }

    [Fact]
    public void ExampleTest6()
    {
        var num = 3;
        Assert.False(new Solution().CheckPerfectNumber(num));
    }

    [Fact]
    public void ExampleTest7()
    {
        var num = 7;
        Assert.False(new Solution().CheckPerfectNumber(num));
    }
}