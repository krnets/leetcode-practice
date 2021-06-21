using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string[] words = {"Hello", "Alaska", "Dad", "Peace"};
        string[] expected = {"Alaska", "Dad"};
        Assert.Equal(expected, new Solution().FindWords(words));
    }

    [Fact]
    public void ExampleTest2()
    {
        string[] words = {"omk"};
        string[] expected = { };
        Assert.Equal(expected, new Solution().FindWords(words));
    }

    [Fact]
    public void ExampleTest3()
    {
        string[] words = {"adsdf", "sfd"};
        string[] expected = {"adsdf", "sfd"};
        Assert.Equal(expected, new Solution().FindWords(words));
    }
}