using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 3, 5, 4, 7};
        var expected = 3;
        Assert.AreEqual(expected, s.FindLengthOfLCIS(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {2, 2, 2, 2, 2};
        var expected = 1;
        Assert.AreEqual(expected, s.FindLengthOfLCIS(nums));
    }
}