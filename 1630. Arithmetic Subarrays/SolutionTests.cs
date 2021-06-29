using System.Linq;
using Xunit;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {4, 6, 5, 9, 3, 7};
        int[] l = {0, 0, 2};
        int[] r = {2, 3, 5};
        bool[] expected = {true, false, true};
        var actual = new Solution().CheckArithmeticSubarrays(nums, l, r);
        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {-12, -9, -3, -12, -6, 15, 20, -25, -20, -15, -10};
        int[] l = {0, 1, 6, 4, 8, 7};
        int[] r = {4, 4, 9, 7, 9, 10};
        bool[] expected = {false, true, false, false, true, true};
        var actual = new Solution().CheckArithmeticSubarrays(nums, l, r);
        Assert.True(expected.SequenceEqual(actual));
    }
}