using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {4, 5, 6, 7, 0, 1, 2};
        int target = 0;
        int expected = 4;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {4, 5, 6, 7, 0, 1, 2};
        int target = 3;
        int expected = -1;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1};
        int target = 0;
        int expected = -1;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }
}