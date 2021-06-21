using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = 2;
        Assert.True(new Solution().DivisorGame(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = 3;
        Assert.False(new Solution().DivisorGame(input));
    }
}