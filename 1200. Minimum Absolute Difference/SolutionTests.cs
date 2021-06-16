using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] arr = {4, 2, 1, 3};
        int[][] expected =
        {
            new[] {1, 2},
            new[] {2, 3},
            new[] {3, 4}
        };
        Assert.Equal(expected, new Solution().MinimumAbsDifference(arr));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] arr = {1, 3, 6, 10, 15};
        int[][] expected =
        {
            new[] {1, 3}
        };
        Assert.Equal(expected, new Solution().MinimumAbsDifference(arr));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] arr = {3, 8, -10, 23, 19, -4, -14, 27};
        int[][] expected =
        {
            new[] {-14, -10},
            new[] {19, 23},
            new[] {23, 27}
        };
        Assert.Equal(expected, new Solution().MinimumAbsDifference(arr));
    }
}