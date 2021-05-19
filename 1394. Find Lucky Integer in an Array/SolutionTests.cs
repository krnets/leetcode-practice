using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] input = {2, 2, 3, 4};
        var expected = 2;
        Assert.AreEqual(expected, s.FindLucky(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2, 2, 3, 3, 3};
        var expected = 3;
        Assert.AreEqual(expected, s.FindLucky(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {2, 2, 2, 3, 3};
        var expected = -1;
        Assert.AreEqual(expected, s.FindLucky(input));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] input = {5};
        var expected = -1;
        Assert.AreEqual(expected, s.FindLucky(input));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] input = {7, 7, 7, 7, 7, 7, 7};
        var expected = 7;
        Assert.AreEqual(expected, s.FindLucky(input));
    }

    [Test]
    public void ExampleTest6()
    {
        int[] input = {4, 3, 2, 2, 4, 1, 3, 4, 3};
        var expected = 3;
        Assert.AreEqual(expected, s.FindLucky(input));
    }
}