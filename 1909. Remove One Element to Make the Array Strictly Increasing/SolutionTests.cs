using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 10, 5, 7};
        Assert.True(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {2, 3, 1, 2};
        Assert.False(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 1, 1};
        Assert.False(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 2, 3};
        Assert.True(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums = {1, 2, 10, 1};
        Assert.True(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] nums = {105, 924, 32, 968};
        Assert.True(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest7()
    {
        int[] nums = {512, 867, 904, 997, 403};
        Assert.True(new Solution().CanBeIncreasing(nums));
    }

    [Fact]
    public void ExampleTest8()
    {
        int[] nums = {541, 783, 433, 744};
        Assert.False(new Solution().CanBeIncreasing(nums));
    }
}