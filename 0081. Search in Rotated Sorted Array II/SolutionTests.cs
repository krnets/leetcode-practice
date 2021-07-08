using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {2, 5, 6, 0, 0, 1, 2};
        int target = 0;
        Assert.True(new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {2, 5, 6, 0, 0, 1, 2};
        int target = 3;
        Assert.False(new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1};
        int target = 2;
        Assert.True(new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 0, 1, 1, 1};
        int target = 0;
        Assert.True(new Solution().Search(nums, target));
    }
}