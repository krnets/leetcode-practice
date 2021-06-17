using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] mat =
        {
            new[] {1, 0, 0},
            new[] {0, 0, 1},
            new[] {1, 0, 0}
        };

        int expected = 1;
        Assert.Equal(expected, new Solution().NumSpecial(mat));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] mat =
        {
            new[] {1, 0, 0},
            new[] {0, 1, 0},
            new[] {0, 0, 1}
        };

        int expected = 3;
        Assert.Equal(expected, new Solution().NumSpecial(mat));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[][] mat =
        {
            new[] {0, 0, 0, 1},
            new[] {1, 0, 0, 0},
            new[] {0, 1, 1, 0},
            new[] {0, 0, 0, 0}
        };

        int expected = 2;
        Assert.Equal(expected, new Solution().NumSpecial(mat));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[][] mat =
        {
            new[] {0, 0, 0, 0, 0},
            new[] {1, 0, 0, 0, 0},
            new[] {0, 1, 0, 0, 0},
            new[] {0, 0, 1, 0, 0},
            new[] {0, 0, 0, 1, 1}
        };

        int expected = 3;
        Assert.Equal(expected, new Solution().NumSpecial(mat));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[][] mat =
        {
            new[] {0, 0},
            new[] {0, 0},
            new[] {1, 0},
        };

        int expected = 1;
        Assert.Equal(expected, new Solution().NumSpecial(mat));
    }
}