using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 3};
        int expected = 3;
        Assert.AreEqual(expected, s.RepeatedNTimes(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {2, 1, 2, 5, 3, 2};
        int expected = 2;
        Assert.AreEqual(expected, s.RepeatedNTimes(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {5, 1, 5, 2, 5, 3, 5, 4};
        int expected = 5;
        Assert.AreEqual(expected, s.RepeatedNTimes(nums));
    }
}