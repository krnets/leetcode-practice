using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 0, 0, 0, 1, 0, 0, 1};
        int k = 2;
        Assert.True(new Solution().KLengthApart(nums, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 0, 0, 1, 0, 1};
        int k = 2;
        Assert.False(new Solution().KLengthApart(nums, k));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 1, 1, 1, 1};
        int k = 0;
        Assert.True(new Solution().KLengthApart(nums, k));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {0, 1, 0, 1};
        int k = 1;
        Assert.True(new Solution().KLengthApart(nums, k));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums = {1, 0, 0, 0, 1, 0, 0, 1, 0};
        int k = 2;
        Assert.True(new Solution().KLengthApart(nums, k));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] nums = {1, 1, 1, 0};
        int k = 3;
        Assert.False(new Solution().KLengthApart(nums, k));
    }
}