using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] matrix =
        {
            new[] {1, 2, 3, 4},
            new[] {5, 1, 2, 3},
            new[] {9, 5, 1, 2}
        };
        Assert.True(new Solution().IsToeplitzMatrix(matrix));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] matrix = {new[] {1, 2}, new[] {2, 2}};
        Assert.False(new Solution().IsToeplitzMatrix(matrix));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] matrix = {new[] {18}, new[] {66}};
        Assert.True(new Solution().IsToeplitzMatrix(matrix));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[][] matrix = {new[] {84}};
        Assert.True(new Solution().IsToeplitzMatrix(matrix));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[][] matrix =
        {
            new[] {11, 74, 0, 93},
            new[] {40, 11, 74, 7}
        };
        Assert.False(new Solution().IsToeplitzMatrix(matrix));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[][] matrix =
        {
            new[] {36, 59, 71, 15, 26, 82, 87},
            new[] {56, 36, 59, 71, 15, 26, 82},
            new[] {15, 0, 36, 59, 71, 15, 26}
        };
        Assert.False(new Solution().IsToeplitzMatrix(matrix));
    }
}