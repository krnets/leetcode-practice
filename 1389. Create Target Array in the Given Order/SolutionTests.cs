using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {0, 1, 2, 3, 4};
        int[] index = {0, 1, 2, 2, 1};
        int[] expected = {0, 4, 1, 3, 2};
        Assert.AreEqual(expected, s.CreateTargetArray(nums, index));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 2, 3, 4, 0};
        int[] index = {0, 1, 2, 3, 0};
        int[] expected = {0, 1, 2, 3, 4};
        Assert.AreEqual(expected, s.CreateTargetArray(nums, index));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1};
        int[] index = {0};
        int[] expected = {1};
        Assert.AreEqual(expected, s.CreateTargetArray(nums, index));
    }
}