using Xunit;
using System.Linq;

public class SolutionTests
{
    [Fact]
    public void ExampleTest1()
    {
        int[] nums = {1, 1, 2};
        int k = new Solution().RemoveDuplicates(nums);
        int[] expectedNums = {1, 2};

        Assert.True(nums.Take(k).SequenceEqual(expectedNums));
    }

    [Fact]
    public void ExampleTest2()
    {
        int[] nums = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
        int k = new Solution().RemoveDuplicates(nums);
        int[] expectedNums = {0, 1, 2, 3, 4};

        Assert.True(nums.Take(k).SequenceEqual(expectedNums));
    }
}