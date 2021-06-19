using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s = "egg";
        var t = "add";
        Assert.True(new Solution().IsIsomorphic(s, t));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s = "foo";
        var t = "bar";
        Assert.False(new Solution().IsIsomorphic(s, t));
    }

    [Fact]
    public void ExampleTest3()
    {
        var s = "paper";
        var t = "title";
        Assert.True(new Solution().IsIsomorphic(s, t));
    }

    [Fact]
    public void ExampleTest4()
    {
        var s = "badc";
        var t = "baba";
        Assert.False(new Solution().IsIsomorphic(s, t));
    }
}