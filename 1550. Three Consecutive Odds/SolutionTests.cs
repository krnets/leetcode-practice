using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] arr = {2, 6, 4, 1};
        Assert.False(new Solution().ThreeConsecutiveOdds(arr));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] arr =
        {
            1, 2, 34, 3, 4, 5, 7, 23, 12
        };
        Assert.True(new Solution().ThreeConsecutiveOdds(arr));
    }
}