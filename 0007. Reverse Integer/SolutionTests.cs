using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 123;
        var expected = 321;

        Assert.AreEqual(expected, s.Reverse(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = -123;
        var expected = -321;

        Assert.AreEqual(expected, s.Reverse(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 120;
        var expected = 21;

        Assert.AreEqual(expected, s.Reverse(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 0;
        var expected = 0;

        Assert.AreEqual(expected, s.Reverse(input));
    }
}