using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "book";
        var expected = true;
        Assert.AreEqual(expected, s.HalvesAreAlike(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "textbook";
        var expected = false;
        Assert.AreEqual(expected, s.HalvesAreAlike(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "MerryChristmas";
        var expected = false;
        Assert.AreEqual(expected, s.HalvesAreAlike(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "AbCdEfGh";
        var expected = true;
        Assert.AreEqual(expected, s.HalvesAreAlike(input));
    }
}