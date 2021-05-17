using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {3, 4, 5, 2};
        var expected = 12;
        Assert.AreEqual(expected, s.MaxProduct(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 5, 4, 5};
        var expected = 16;
        Assert.AreEqual(expected, s.MaxProduct(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {3, 7};
        var expected = 12;
        Assert.AreEqual(expected, s.MaxProduct(nums));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums = {10, 2, 5, 2};
        var expected = 36;
        Assert.AreEqual(expected, s.MaxProduct(nums));
    }
}