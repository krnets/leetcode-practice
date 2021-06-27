using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] mat = {new[] {1, 2}, new[] {3, 4}};
        int r = 1;
        int c = 4;
        int[][] expected = {new[] {1, 2, 3, 4}};
        Assert.Equal(expected, new Solution().MatrixReshape(mat, r, c));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] mat = {new[] {1, 2}, new[] {3, 4}};
        int r = 2;
        int c = 4;
        int[][] expected = {new[] {1, 2}, new[] {3, 4}};
        Assert.Equal(expected, new Solution().MatrixReshape(mat, r, c));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] mat =
        {
            new[] {1, 2, 3, 4},
            new[] {5, 6, 7, 8},
            new[] {9, 10, 11, 12},
            new[] {13, 14, 15, 16},
            new[] {17, 18, 19, 20}
        };
        int r = 42;
        int c = 5;
        int[][] expected =
        {
            new[] {1, 2, 3, 4},
            new[] {5, 6, 7, 8},
            new[] {9, 10, 11, 12},
            new[] {13, 14, 15, 16},
            new[] {17, 18, 19, 20}
        };

        Assert.Equal(expected, new Solution().MatrixReshape(mat, r, c));
    }
}