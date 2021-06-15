using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "00110";
        var expected = 1;
        Assert.Equal(expected, new Solution().MinFlipsMonoIncr(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "010110";
        var expected = 2;
        Assert.Equal(expected, new Solution().MinFlipsMonoIncr(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "00011000";
        var expected = 2;
        Assert.Equal(expected, new Solution().MinFlipsMonoIncr(input));
    }

    [Fact]
    public void ExampleTest4()
    {
        var input = "0101100011";
        var expected = 3;
        Assert.Equal(expected, new Solution().MinFlipsMonoIncr(input));
    }
}