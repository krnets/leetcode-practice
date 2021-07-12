using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {-1, 0, 3, 5, 9, 12};
        int target = 9;
        int expected = 4;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {-1, 0, 3, 5, 9, 12};
        int target = 2;
        int expected = -1;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {5};
        int target = 5;
        int expected = 0;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }
    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {2,5};
        int target = 5;
        int expected = 1;
        Assert.Equal(expected, new Solution().Search(nums, target));
    }
}