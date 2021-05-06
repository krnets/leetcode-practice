using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 14;
        var expected = 6;
        Assert.AreEqual(expected, s.NumberOfSteps(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 8;
        var expected = 4;
        Assert.AreEqual(expected, s.NumberOfSteps(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 123;
        var expected = 12;
        Assert.AreEqual(expected, s.NumberOfSteps(input));
    }
}