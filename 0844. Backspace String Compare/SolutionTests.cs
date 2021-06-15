using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s = "ab#c";
        var t = "ad#c";
        Assert.True(new Solution().BackspaceCompare(s, t));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s = "ab##";
        var t = "c#d#";
        Assert.True(new Solution().BackspaceCompare(s, t));
    }

    [Fact]
    public void ExampleTest3()
    {
        var s = "a##c";
        var t = "#a#c";
        Assert.True(new Solution().BackspaceCompare(s, t));
    }

    [Fact]
    public void ExampleTest4()
    {
        var s = "a#c";
        var t = "b";
        Assert.False(new Solution().BackspaceCompare(s, t));
    }

    [Fact]
    public void ExampleTest5()
    {
        var s = "y#fo##f";
        var t = "y#f#o##f";
        Assert.True(new Solution().BackspaceCompare(s, t));
    }
}