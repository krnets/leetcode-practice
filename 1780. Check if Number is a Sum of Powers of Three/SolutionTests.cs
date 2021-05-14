using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 12;
        var expected = true;
        Assert.AreEqual(expected, s.CheckPowersOfThree(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 91;
        var expected = true;
        Assert.AreEqual(expected, s.CheckPowersOfThree(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 21;
        var expected = false;
        Assert.AreEqual(expected, s.CheckPowersOfThree(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 8854985;
        var expected = false;
        Assert.AreEqual(expected, s.CheckPowersOfThree(input));
    }
}