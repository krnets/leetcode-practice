using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s1 = "bank";
        var s2 = "kanb";
        Assert.True(new Solution().AreAlmostEqual(s1, s2));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s1 = "attack";
        var s2 = "defend";
        Assert.False(new Solution().AreAlmostEqual(s1, s2));
    }

    [Fact]
    public void ExampleTest3()
    {
        var s1 = "kelb";
        var s2 = "kelb";
        Assert.True(new Solution().AreAlmostEqual(s1, s2));
    }

    [Fact]
    public void ExampleTest4()
    {
        var s1 = "abcd";
        var s2 = "dcba";
        Assert.False(new Solution().AreAlmostEqual(s1, s2));
    }
}