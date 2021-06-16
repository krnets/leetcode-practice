using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "hello";
        var expected = "holle";
        Assert.Equal(expected, new Solution().ReverseVowels(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "leetcode";
        var expected = "leotcede";
        Assert.Equal(expected, new Solution().ReverseVowels(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "aA";
        var expected = "Aa";
        Assert.Equal(expected, new Solution().ReverseVowels(input));
    }
}