using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string input = "abcde";
        string[] words = {"a", "bb", "acd", "ace"};
        int expected = 3;
        Assert.Equal(expected, new Solution().NumMatchingSubseq(input, words));
    }

    [Fact]
    public void ExampleTest2()
    {
        string input = "dsahjpjauf";
        string[] words = {"ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax"};
        int expected = 2;
        Assert.Equal(expected, new Solution().NumMatchingSubseq(input, words));
    }
}