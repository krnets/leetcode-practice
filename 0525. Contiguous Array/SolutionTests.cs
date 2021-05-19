using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {0, 1};
        var expected = 2;
        Assert.AreEqual(expected, s.FindMaxLength(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {0, 1, 0};
        var expected = 2;
        Assert.AreEqual(expected, s.FindMaxLength(nums));
    }
}