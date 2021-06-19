using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "ab";
        var goal = "ba";
        Assert.True(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "ab";
        var goal = "ab";
        Assert.False(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "aa";
        var goal = "aa";
        Assert.True(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "aaaaaaabc";
        var goal = "aaaaaaacb";
        Assert.True(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest5()
    {
        var input = "abcd";
        var goal = "badc";
        Assert.False(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest6()
    {
        var input = "abcaa";
        var goal = "abcbb";
        Assert.False(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest7()
    {
        var input = "abab";
        var goal = "abab";
        Assert.True(new Solution().BuddyStrings(input, goal));
    }


    [Fact]
    public void ExampleTest8()
    {
        var input = "abcd";
        var goal = "abcd";
        Assert.False(new Solution().BuddyStrings(input, goal));
    }

    [Fact]
    public void ExampleTest9()
    {
        var input = "abcd";
        var goal = "abcde";
        Assert.False(new Solution().BuddyStrings(input, goal));
    }
}