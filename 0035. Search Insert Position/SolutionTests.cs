using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 3, 5, 6};
        int target = 5;
        int expected = 2;
        Assert.Equal(expected, new Solution().SearchInsert(nums, target));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 3, 5, 6};
        int target = 2;
        int expected = 1;
        Assert.Equal(expected, new Solution().SearchInsert(nums, target));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 3, 5, 6};
        int target = 7;
        int expected = 4;
        Assert.Equal(expected, new Solution().SearchInsert(nums, target));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 3, 5, 6};
        int target = 0;
        int expected = 0;
        Assert.Equal(expected, new Solution().SearchInsert(nums, target));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums = {1};
        int target = 0;
        int expected = 0;
        Assert.Equal(expected, new Solution().SearchInsert(nums, target));
    }
}