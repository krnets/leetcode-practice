using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "1001";
        Assert.False(new Solution().CheckOnesSegment(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "110";
        Assert.True(new Solution().CheckOnesSegment(input));
    }
    [Fact]
    public void ExampleTest3()
    {
        var input = "1";
        Assert.True(new Solution().CheckOnesSegment(input));
    }
}