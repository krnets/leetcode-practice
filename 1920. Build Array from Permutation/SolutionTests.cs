using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {0, 2, 1, 5, 3, 4};
        int[] expected = {0, 1, 2, 4, 5, 3};
        Assert.Equal(expected, new Solution().BuildArray(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {5, 0, 1, 2, 3, 4};
        int[] expected = {4, 5, 0, 1, 2, 3};
        Assert.Equal(expected, new Solution().BuildArray(nums));
    }
}