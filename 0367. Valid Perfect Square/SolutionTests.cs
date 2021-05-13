using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest_16()
    {
        var input = 16;
        var expected = true;
        Assert.AreEqual(expected, s.IsPerfectSquare(input));
    }

    [Test]
    public void ExampleTest_8()
    {
        var input = 8;
        var expected = false;
        Assert.AreEqual(expected, s.IsPerfectSquare(input));
    }

    [Test]
    public void ExampleTest_14()
    {
        var input = 14;
        var expected = false;
        Assert.AreEqual(expected, s.IsPerfectSquare(input));
    }

    [Test]
    public void ExampleTest_1()
    {
        var input = 1;
        var expected = true;
        Assert.AreEqual(expected, s.IsPerfectSquare(input));
    }

    [Test]
    public void ExampleTest_9()
    {
        var input = 9;
        var expected = true;
        Assert.AreEqual(expected, s.IsPerfectSquare(input));
    }

    [Test]
    public void ExampleTest_2147483647()
    {
        var input = 2147483647;
        var expected = false;
        Assert.AreEqual(expected, s.IsPerfectSquare(input));
    }
}