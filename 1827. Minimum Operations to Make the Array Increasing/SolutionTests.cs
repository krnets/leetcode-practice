using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 1, 1};
        var expected = 3;
        Assert.AreEqual(expected, s.MinOperations(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 5, 2, 4, 1};
        var expected = 14;
        Assert.AreEqual(expected, s.MinOperations(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {8};
        var expected = 0;
        Assert.AreEqual(expected, s.MinOperations(nums));
    }
}