using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int numRows = 5;
        int[][] expected =
        {
            new[] {1},
            new[] {1, 1},
            new[] {1, 2, 1},
            new[] {1, 3, 3, 1},
            new[] {1, 4, 6, 4, 1}
        };
        Assert.Equal(expected, new Solution().Generate(numRows));
    }

    [Fact]
    public void ExampleTest2()
    {
        int numRows = 1;
        int[][] expected =
        {
            new[] {1},
        };
        Assert.Equal(expected, new Solution().Generate(numRows));
    }
}