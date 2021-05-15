using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "USA";
        var expected = true;
        Assert.AreEqual(expected, s.DetectCapitalUse(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "FlaG";
        var expected = false;
        Assert.AreEqual(expected, s.DetectCapitalUse(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "g";
        var expected = true;
        Assert.AreEqual(expected, s.DetectCapitalUse(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "ggg";
        var expected = true;
        Assert.AreEqual(expected, s.DetectCapitalUse(input));
    }
}