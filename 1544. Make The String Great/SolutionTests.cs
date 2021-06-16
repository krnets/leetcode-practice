using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "leEeetcode";
        var expected = "leetcode";
        Assert.Equal(expected, new Solution().MakeGood(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "abBAcC";
        var expected = "";
        Assert.Equal(expected, new Solution().MakeGood(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "s";
        var expected = "s";
        Assert.Equal(expected, new Solution().MakeGood(input));
    }
}