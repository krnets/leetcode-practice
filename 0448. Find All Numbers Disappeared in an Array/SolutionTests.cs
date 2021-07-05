using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {4, 3, 2, 7, 8, 2, 3, 1};
        int[] expected = {5, 6};
        Assert.Equal(expected, new Solution().FindDisappearedNumbers(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 1};
        int[] expected = {2};
        Assert.Equal(expected, new Solution().FindDisappearedNumbers(nums));
    }
}