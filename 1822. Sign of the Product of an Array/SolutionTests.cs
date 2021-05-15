using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {-1, -2, -3, -4, 3, 2, 1};
        var expected = 1;
        Assert.AreEqual(expected, s.ArraySign(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 5, 0, 2, -3};
        var expected = 0;
        Assert.AreEqual(expected, s.ArraySign(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {-1, 1, -1, 1, -1};
        var expected = -1;
        Assert.AreEqual(expected, s.ArraySign(nums));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums =
        {
            41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10,
            3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41
        };
        var expected = -1;
        Assert.AreEqual(expected, s.ArraySign(nums));
    }
}