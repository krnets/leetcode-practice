using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = 19;
        Assert.True(new Solution().IsHappy(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = 2;
        Assert.False(new Solution().IsHappy(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = 7;
        Assert.True(new Solution().IsHappy(input));
    }
}