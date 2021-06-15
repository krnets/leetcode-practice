using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var sequence = "ababc";
        var word = "ab";
        int expected = 2;
        Assert.Equal(expected, new Solution().MaxRepeating(sequence, word));
    }

    [Fact]
    public void ExampleTest2()
    {
        var sequence = "ababc";
        var word = "ba";
        int expected = 1;
        Assert.Equal(expected, new Solution().MaxRepeating(sequence, word));
    }

    [Fact]
    public void ExampleTest3()
    {
        var sequence = "ababc";
        var word = "ac";
        int expected = 0;
        Assert.Equal(expected, new Solution().MaxRepeating(sequence, word));
    }


    [Fact]
    public void ExampleTest4()
    {
        var sequence = "a";
        var word = "a";
        int expected = 1;
        Assert.Equal(expected, new Solution().MaxRepeating(sequence, word));
    }

    [Fact]
    public void ExampleTest5()
    {
        var sequence = "aaabaaaabaaabaaaabaaaabaaaabaaaaba";
        var word = "aaaba";
        int expected = 5;
        Assert.Equal(expected, new Solution().MaxRepeating(sequence, word));
    }
}