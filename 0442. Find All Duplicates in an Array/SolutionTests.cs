using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {4, 3, 2, 7, 8, 2, 3, 1};
        int[] expected = {2, 3};
        Assert.Equal(expected, new Solution().FindDuplicates(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 1, 2};
        int[] expected = {1};
        Assert.Equal(expected, new Solution().FindDuplicates(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = { };
        int[] expected = { };
        Assert.Equal(expected, new Solution().FindDuplicates(nums));
    }
}