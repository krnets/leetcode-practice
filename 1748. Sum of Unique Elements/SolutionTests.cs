using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 3, 2};
        var expected = 4;
        Assert.AreEqual(expected, s.SumOfUnique(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 1, 1, 1, 1};
        var expected = 0;
        Assert.AreEqual(expected, s.SumOfUnique(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 2, 3, 4, 5};
        var expected = 15;
        Assert.AreEqual(expected, s.SumOfUnique(nums));
    }
}