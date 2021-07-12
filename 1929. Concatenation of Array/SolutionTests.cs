using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 1};
        int[] expected = {1, 2, 1, 1, 2, 1};
        Assert.Equal(expected, new Solution().GetConcatenation(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {1, 3, 2, 1};
        int[] expected = {1, 3, 2, 1, 1, 3, 2, 1};
        Assert.Equal(expected, new Solution().GetConcatenation(nums));
    }
}