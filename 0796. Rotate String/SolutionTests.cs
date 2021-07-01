using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s = "abcde";
        var goal = "cdeab";
        Assert.True(new Solution().RotateString(s, goal));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s = "abcde";
        var goal = "abced";
        Assert.False(new Solution().RotateString(s, goal));
    }
    [Fact]
    public void ExampleTest3()
    {
        var s = "";
        var goal = "";
        Assert.True(new Solution().RotateString(s, goal));
    }
}
