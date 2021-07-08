using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] matrix = {new[] {1, 5, 9}, new[] {10, 11, 13}, new[] {12, 13, 15}};
        int k = 8;
        int expected = 13;
        Assert.Equal(expected, new Solution().KthSmallest(matrix, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] matrix = {new[] {-5}};
        int k = 1;
        int expected = -5;
        Assert.Equal(expected, new Solution().KthSmallest(matrix, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] matrix = {new[] {1, 2}, new[] {1, 3}};
        int k = 2;
        int expected = 1;
        Assert.Equal(expected, new Solution().KthSmallest(matrix, k));
    }
}