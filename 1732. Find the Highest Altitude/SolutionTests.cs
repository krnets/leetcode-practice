using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {-5, 1, 5, 0, -7};
        var expected = 1;
        Assert.AreEqual(expected, s.LargestAltitude(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {-4, -3, -2, -1, 4, 3, 2};
        var expected = 0;
        Assert.AreEqual(expected, s.LargestAltitude(input));
    }
}