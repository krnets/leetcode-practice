using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var s1 = "ab";
        var s2 = "eidbaooo";
        Assert.True(new Solution().CheckInclusion(s1, s2));
    }

    [Fact]
    public void ExampleTest2()
    {
        var s1 = "ab";
        var s2 = "eidboaooo";
        Assert.False(new Solution().CheckInclusion(s1, s2));
    }
}