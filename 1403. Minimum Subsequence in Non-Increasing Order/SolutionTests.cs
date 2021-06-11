using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {4, 3, 10, 9, 8};
        int[] expected = {10, 9};
        Assert.Equal(expected, new Solution().MinSubsequence(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {4, 4, 7, 6, 7};
        int[] expected = {7, 7, 6};
        Assert.Equal(expected, new Solution().MinSubsequence(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = {6};
        int[] expected = {6};
        Assert.Equal(expected, new Solution().MinSubsequence(nums));
    }
}