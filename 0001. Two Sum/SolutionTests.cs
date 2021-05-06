using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        int[] expected = {0, 1};
        Assert.AreEqual(expected, s.TwoSum(nums, target));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {3, 2, 4};
        int target = 6;
        int[] expected = {1, 2};
        Assert.AreEqual(expected, s.TwoSum(nums, target));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {3, 3};
        int target = 6;
        int[] expected = {0, 1};
        Assert.AreEqual(expected, s.TwoSum(nums, target));
    }
}