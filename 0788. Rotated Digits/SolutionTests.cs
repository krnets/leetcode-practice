using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        var input = 10;
        var expected = 4;
        Assert.Equal(expected, new Solution().RotatedDigits(input));
    }

    [Fact]
    public void ExampleTest2()
    {
        var input = 857;
        var expected = 247;
        Assert.Equal(expected, new Solution().RotatedDigits(input));
    }
}