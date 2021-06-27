using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        char[][] matrix =
        {
            new[] {'1', '0', '1', '0', '0'},
            new[] {'1', '0', '1', '1', '1'},
            new[] {'1', '1', '1', '1', '1'},
            new[] {'1', '0', '0', '1', '0'}
        };
        var expected = 4;
        Assert.Equal(expected, new Solution().MaximalSquare(matrix));
    }

    [Fact]
    public void ExampleTest2()
    {
        char[][] matrix =
        {
            new[] {'0', '1'},
            new[] {'1', '0'}
        };
        var expected = 1;
        Assert.Equal(expected, new Solution().MaximalSquare(matrix));
    }

    [Fact]
    public void ExampleTest3()
    {
        char[][] matrix =
        {
            new[] {'0'}
        };
        var expected = 0;
        Assert.Equal(expected, new Solution().MaximalSquare(matrix));
    }


    [Fact]
    public void ExampleTest4()
    {
        char[][] matrix =
        {
            new[] {'1', '0', '1', '0'},
            new[] {'1', '0', '1', '1'},
            new[] {'1', '0', '1', '1'},
            new[] {'1', '1', '1', '1'}
        };
        var expected = 4;
        Assert.Equal(expected, new Solution().MaximalSquare(matrix));
    }

    [Fact]
    public void ExampleTest5()
    {
        char[][] matrix =
        {
            new[] {'1', '1', '1', '1', '1', '1', '1', '1'},
            new[] {'1', '1', '1', '1', '1', '1', '1', '0'},
            new[] {'1', '1', '1', '1', '1', '1', '1', '0'},
            new[] {'1', '1', '1', '1', '1', '0', '0', '0'},
            new[] {'0', '1', '1', '1', '1', '0', '0', '0'}
        };
        var expected = 16;
        Assert.Equal(expected, new Solution().MaximalSquare(matrix));
    }
}