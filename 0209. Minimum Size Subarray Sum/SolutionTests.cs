using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int target = 7;
        int[] nums = {2, 3, 1, 2, 4, 3};
        int expected = 2;
        Assert.Equal(expected, new Solution().MinSubArrayLen(target, nums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int target = 4;
        int[] nums = {1, 4, 4};
        int expected = 1;
        Assert.Equal(expected, new Solution().MinSubArrayLen(target, nums));
    }

    [Fact]
    public void ExampleTest3()
    {
        int target = 11;
        int[] nums = {1, 1, 1, 1, 1, 1, 1, 1};
        int expected = 0;
        Assert.Equal(expected, new Solution().MinSubArrayLen(target, nums));
    }
}