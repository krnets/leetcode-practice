using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = "32";
        var expected = 3;
        Assert.Equal(expected, new Solution().MinPartitions(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = "82734";
        var expected = 8;
        Assert.Equal(expected, new Solution().MinPartitions(input));
    }

    [Fact]
    public void ExampleTest3()
    {
        var input = "27346209830709182346";
        var expected = 9;
        Assert.Equal(expected, new Solution().MinPartitions(input));
    }
}