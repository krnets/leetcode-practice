using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "a1c1e1";
        var expected = "abcdef";
        Assert.AreEqual(expected, s.ReplaceDigits(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "a1b2c3d4e";
        var expected = "abbdcfdhe";
        Assert.AreEqual(expected, s.ReplaceDigits(input));
    }
}