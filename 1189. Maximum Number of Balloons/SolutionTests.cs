using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "nlaebolko";
        var expected = 1;
        Assert.Equal(expected, new Solution().MaxNumberOfBalloons(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "loonbalxballpoon";
        var expected = 2;
        Assert.Equal(expected, new Solution().MaxNumberOfBalloons(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "leetcode";
        var expected = 0;
        Assert.Equal(expected, new Solution().MaxNumberOfBalloons(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "lloo";
        var expected = 0;
        Assert.Equal(expected, new Solution().MaxNumberOfBalloons(input));
    }
}