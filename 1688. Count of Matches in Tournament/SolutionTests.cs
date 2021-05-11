using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 7;
        var expected = 6;
        Assert.AreEqual(expected, s.NumberOfMatches(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 14;
        var expected = 13;
        Assert.AreEqual(expected, s.NumberOfMatches(input));
    }
}