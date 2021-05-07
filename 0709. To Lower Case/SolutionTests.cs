using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "Hello";
        var expected = "hello";
        Assert.AreEqual(expected, s.ToLowerCase(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "here";
        var expected = "here";
        Assert.AreEqual(expected, s.ToLowerCase(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "LOVELY";
        var expected = "lovely";
        Assert.AreEqual(expected, s.ToLowerCase(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "al&phaBET";
        var expected = "al&phabet";
        Assert.AreEqual(expected, s.ToLowerCase(input));
    }
}