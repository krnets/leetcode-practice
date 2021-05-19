using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {4, 2, 3};
        var expected = true;
        Assert.AreEqual(expected, s.CheckPossibility(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {4, 2, 1};
        var expected = false;
        Assert.AreEqual(expected, s.CheckPossibility(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {3, 4, 2, 3};
        var expected = false;
        Assert.AreEqual(expected, s.CheckPossibility(nums));
    }
}