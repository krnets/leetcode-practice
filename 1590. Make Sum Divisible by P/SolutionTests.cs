using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {3, 1, 4, 2};
        int p = 6;
        int expected = 1;
        Assert.Equal(expected, new Solution().MinSubarray(nums, p));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {6, 3, 5, 2};
        int p = 9;
        int expected = 2;
        Assert.Equal(expected, new Solution().MinSubarray(nums, p));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {1, 2, 3};
        int p = 3;
        int expected = 0;
        Assert.Equal(expected, new Solution().MinSubarray(nums, p));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {1, 2, 3};
        int p = 7;
        int expected = -1;
        Assert.Equal(expected, new Solution().MinSubarray(nums, p));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums = {1000000000, 1000000000, 1000000000};
        int p = 3;
        int expected = 0;
        Assert.Equal(expected, new Solution().MinSubarray(nums, p));
    }

    [Fact]
    public void ExampleTest6()
    {
        int[] nums = {1};
        int p = 1;
        int expected = 0;
        Assert.Equal(expected, new Solution().MinSubarray(nums, p));
    }
}