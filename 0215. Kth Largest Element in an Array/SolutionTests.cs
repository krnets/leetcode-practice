using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {3, 2, 1, 5, 6, 4};
        int k = 2;
        int expected = 5;
        Assert.Equal(expected, new Solution().FindKthLargest(nums, k));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {3, 2, 3, 1, 2, 4, 5, 5, 6};
        int k = 4;
        int expected = 4;
        Assert.Equal(expected, new Solution().FindKthLargest(nums, k));
    }
}