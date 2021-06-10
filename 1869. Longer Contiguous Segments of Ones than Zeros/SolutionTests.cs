using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        string input = "1101";
        Assert.True(new Solution().CheckZeroOnes(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        string input = "111000";
        Assert.False(new Solution().CheckZeroOnes(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        string input = "110100010";
        Assert.False(new Solution().CheckZeroOnes(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        string input = "1";
        Assert.True(new Solution().CheckZeroOnes(input));
    }
}