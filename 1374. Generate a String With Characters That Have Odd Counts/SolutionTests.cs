using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var n = 4;
        var expected = "pppz";
        Assert.AreEqual(expected, s.GenerateTheString(n));
    }

    [Test]
    public void ExampleTest2()
    {
        var n = 2;
        var expected = "xy";
        Assert.AreEqual(expected, s.GenerateTheString(n));
    }

    [Test]
    public void ExampleTest3()
    {
        var n = 7;
        var expected = "holasss";
        Assert.AreEqual(expected, s.GenerateTheString(n));
    }
}