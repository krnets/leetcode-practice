using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest_16()
    {
        var input = 16;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfFour(input));
    }

    [Test]
    public void ExampleTest_5()
    {
        var input = 5;
        var expected = false;
        Assert.AreEqual(expected, s.IsPowerOfFour(input));
    }

    [Test]
    public void ExampleTest_1()
    {
        var input = 1;
        var expected = true;
        Assert.AreEqual(expected, s.IsPowerOfFour(input));
    }

    [Test]
    public void ExampleTest_2()
    {
        var input = 2;
        var expected = false;
        Assert.AreEqual(expected, s.IsPowerOfFour(input));
    }
}