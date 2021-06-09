using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 4, 5};
        Assert.True(new Solution().IncreasingTriplet(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {5, 4, 3, 2, 1};
        Assert.False(new Solution().IncreasingTriplet(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {2, 1, 5, 0, 4, 6};
        Assert.True(new Solution().IncreasingTriplet(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {2, 4, -2, -3};
        Assert.False(new Solution().IncreasingTriplet(nums));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums =
        {
            1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0, 0, -1, -1, -1, -1, 3
        };
        Assert.True(new Solution().IncreasingTriplet(nums));
    }
}