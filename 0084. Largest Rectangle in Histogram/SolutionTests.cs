using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] heights = {2, 1, 5, 6, 2, 3};
        var expected = 10;
        Assert.Equal(expected, new Solution().LargestRectangleArea(heights));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] heights = {2, 4};
        var expected = 4;
        Assert.Equal(expected, new Solution().LargestRectangleArea(heights));
    }
}