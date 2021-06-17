using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[][] dominoes =
        {
            new[] {1, 2}, new[] {2, 1}, new[] {3, 4}, new[] {5, 6}
        };
        var expected = 1;
        Assert.Equal(expected, new Solution().NumEquivDominoPairs(dominoes));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[][] dominoes =
        {
            new[] {1, 2}, 
            new[] {1, 2}, 
            new[] {1, 1}, 
            new[] {1, 2}, 
            new[] {2, 2},
        };
        var expected = 3;
        Assert.Equal(expected, new Solution().NumEquivDominoPairs(dominoes));
    }
}