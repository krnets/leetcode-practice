using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 3, 1, 1, 3};
        var expected = 4;
        Assert.AreEqual(expected, s.NumIdenticalPairs(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 1, 1, 1};
        var expected = 6;
        Assert.AreEqual(expected, s.NumIdenticalPairs(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {1, 2, 3};
        var expected = 0;
        Assert.AreEqual(expected, s.NumIdenticalPairs(input));
    }
}