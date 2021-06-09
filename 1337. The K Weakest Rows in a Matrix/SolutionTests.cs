using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] mat =
        {
            new[] {1, 1, 0, 0, 0},
            new[] {1, 1, 1, 1, 0},
            new[] {1, 0, 0, 0, 0},
            new[] {1, 1, 0, 0, 0},
            new[] {1, 1, 1, 1, 1}
        };
        int k = 3;
        int[] expected = {2, 0, 3};
        Assert.Equal(expected, new Solution().KWeakestRows(mat, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] mat =
        {
            new[] {1, 0, 0, 0},
            new[] {1, 1, 1, 1},
            new[] {1, 0, 0, 0},
            new[] {1, 0, 0, 0},
        };
        int k = 2;
        int[] expected = {0, 2};
        Assert.Equal(expected, new Solution().KWeakestRows(mat, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] mat =
        {
            new[] {1, 0},
            new[] {1, 0},
            new[] {1, 0},
            new[] {1, 1},
        };
        int k = 4;
        int[] expected = {0, 1, 2, 3};
        Assert.Equal(expected, new Solution().KWeakestRows(mat, k));
    }
}