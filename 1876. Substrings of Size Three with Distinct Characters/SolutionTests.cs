using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "xyzzaz";
        var expected = 1;
        Assert.Equal(expected, new Solution().CountGoodSubstrings(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "aababcabc";
        var expected = 4;
        Assert.Equal(expected, new Solution().CountGoodSubstrings(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "x";
        var expected = 0;
        Assert.Equal(expected, new Solution().CountGoodSubstrings(input));
    }
}