using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "III";
        int expected = 3;

        Assert.AreEqual(expected, s.RomanToInt(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "IV";
        int expected = 4;

        Assert.AreEqual(expected, s.RomanToInt(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "IX";
        int expected = 9;
        Assert.AreEqual(expected, s.RomanToInt(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "LVIII";
        var expected = 58;

        Assert.AreEqual(expected, s.RomanToInt(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "MCMXCIV";
        var expected = 1994;
        Assert.AreEqual(expected, s.RomanToInt(input));
    }
}