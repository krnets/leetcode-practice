using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 4;
        var expected = 2;
        Assert.AreEqual(expected, s.MySqrt(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 8;
        var expected = 2;
        Assert.AreEqual(expected, s.MySqrt(input));
    }
}