using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] grid = {new[] {1, 3, 1}, new[] {1, 5, 1}, new[] {4, 2, 1}};
        int expected = 7;
        Assert.Equal(expected, new Solution().MinPathSum(grid));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] grid = {new[] {1, 2, 3}, new[] {4, 5, 6}};
        int expected = 12;
        Assert.Equal(expected, new Solution().MinPathSum(grid));
    }
}