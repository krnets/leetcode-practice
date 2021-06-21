using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] widths =
            {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        var s = "abcdefghijklmnopqrstuvwxyz";
        int[] expected = {3, 60};
        Assert.Equal(expected, new Solution().NumberOfLines(widths, s));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] widths =
            {4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        var s = "bbbcccdddaaa";
        int[] expected = {2, 4};
        Assert.Equal(expected, new Solution().NumberOfLines(widths, s));
    }
}