using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
        string[] banned = {"hit"};
        string expected = "ball";
        Assert.Equal(expected, new Solution().MostCommonWord(paragraph, banned));
    }

    [Fact]
    public void ExampleTest2()
    {
        var paragraph = "a.";
        var banned = new string[] { };
        string expected = "a";
        Assert.Equal(expected, new Solution().MostCommonWord(paragraph, banned));
    }

    [Fact]
    public void ExampleTest3()
    {
        var paragraph = "a, a, a, a, b,b,b,c, c";
        string[] banned = {"a"};
        string expected = "b";
        Assert.Equal(expected, new Solution().MostCommonWord(paragraph, banned));
    }
}