using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {100, 4, 200, 1, 3, 2};
        int expected = 4;
        Assert.Equal(expected, new Solution().LongestConsecutive(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {0, 3, 7, 2, 5, 8, 4, 6, 0, 1};
        int expected = 9;
        Assert.Equal(expected, new Solution().LongestConsecutive(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {0};
        int expected = 1;
        Assert.Equal(expected, new Solution().LongestConsecutive(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {0, 0};
        int expected = 1;
        Assert.Equal(expected, new Solution().LongestConsecutive(nums));
    }
}