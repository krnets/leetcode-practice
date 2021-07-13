using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = 6;
        Assert.True(new Solution().IsUgly(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = 8;
        Assert.True(new Solution().IsUgly(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = 14;
        Assert.False(new Solution().IsUgly(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = 1;
        Assert.True(new Solution().IsUgly(input));
    }

    [Fact]
    public void ExampleTest5()
    {
        var input = 0;
        Assert.False(new Solution().IsUgly(input));
    }
}