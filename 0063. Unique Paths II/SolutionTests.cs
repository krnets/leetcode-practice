using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] obstacleGrid = {new[] {0, 0, 0}, new[] {0, 1, 0}, new[] {0, 0, 0}};
        int expected = 2;
        Assert.Equal(expected, new Solution().UniquePathsWithObstacles(obstacleGrid));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] obstacleGrid = {new[] {0, 1}, new[] {0, 0}};
        int expected = 1;
        Assert.Equal(expected, new Solution().UniquePathsWithObstacles(obstacleGrid));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] obstacleGrid = {new[] {1}};
        int expected = 0;
        Assert.Equal(expected, new Solution().UniquePathsWithObstacles(obstacleGrid));
    }
}