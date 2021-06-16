using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s = "ADOBECODEBANC";
        var t = "ABC";
        var expected = "BANC";
        Assert.Equal(expected, new Solution().MinWindow(s, t));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s = "a";
        var t = "a";
        var expected = "a";
        Assert.Equal(expected, new Solution().MinWindow(s, t));
    }

    [Fact]
    public void ExampleTest3()
    {
        var s = "a";
        var t = "aa";
        var expected = "";
        Assert.Equal(expected, new Solution().MinWindow(s, t));
    }
}