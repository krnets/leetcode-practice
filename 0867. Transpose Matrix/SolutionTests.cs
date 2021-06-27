using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] matrix = {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}};
        int[][] expected = {new[] {1, 4, 7}, new[] {2, 5, 8}, new[] {3, 6, 9}};
        Assert.Equal(expected, new Solution().Transpose(matrix));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] matrix = {new[] {1, 2, 3}, new[] {4, 5, 6}};
        int[][] expected = {new[] {1, 4}, new[] {2, 5}, new[] {3, 6}};
        Assert.Equal(expected, new Solution().Transpose(matrix));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] matrix = {new[] {2, 4, -1}, new[] {-10, 5, 11}, new[] {18, -7, 6}};
        int[][] expected = {new[] {2, -10, 18}, new[] {4, 5, -7}, new[] {-1, 11, 6}};
        Assert.Equal(expected, new Solution().Transpose(matrix));
    }
}