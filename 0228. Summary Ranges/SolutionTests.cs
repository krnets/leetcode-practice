using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {0, 1, 2, 4, 5, 7};
        string[] expected = {"0->2", "4->5", "7"};
        Assert.Equal(expected, new Solution().SummaryRanges(nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {0, 2, 3, 4, 6, 8, 9};
        string[] expected = {"0", "2->4", "6", "8->9"};
        Assert.Equal(expected, new Solution().SummaryRanges(nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int[] nums = { };
        string[] expected = { };
        Assert.Equal(expected, new Solution().SummaryRanges(nums));
    }

    [Fact]
    public void ExampleTest4()
    {
        int[] nums = {-1};
        string[] expected = {"-1"};
        Assert.Equal(expected, new Solution().SummaryRanges(nums));
    }

    [Fact]
    public void ExampleTest5()
    {
        int[] nums = {0};
        string[] expected = {"0"};
        Assert.Equal(expected, new Solution().SummaryRanges(nums));
    }
}