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
        int expected = 6;
        Assert.Equal(expected, new Solution().MaximalRectangle(matrix));
    }

    [Fact]
    public void ExampleTest2()
    {
        char[][] matrix = {new[] {'0'}};
        int expected = 0;
        Assert.Equal(expected, new Solution().MaximalRectangle(matrix));
    }

    [Fact]
    public void ExampleTest3()
    {
        char[][] matrix = {new[] {'0'}};
        int expected = 0;
        Assert.Equal(expected, new Solution().MaximalRectangle(matrix));
    }

    [Fact]
    public void ExampleTest4()
    {
        char[][] matrix = {new[] {'1'}};
        int expected = 1;
        Assert.Equal(expected, new Solution().MaximalRectangle(matrix));
    }

    [Fact]
    public void ExampleTest5()
    {
        char[][] matrix = {new[] {'0', '0'}};
        int expected = 0;
        Assert.Equal(expected, new Solution().MaximalRectangle(matrix));
    }

    [Fact]
    public void ExampleTest6()
    {
        char[][] matrix = {new char[0]};
        int expected = 0;
        Assert.Equal(expected, new Solution().MaximalRectangle(matrix));
    }
}