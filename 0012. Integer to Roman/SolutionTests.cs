using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = 3;
        var expected = "III";
        Assert.AreEqual(expected, s.IntToRoman(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 4;
        var expected = "IV";
        Assert.AreEqual(expected, s.IntToRoman(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 9;
        var expected = "IX";
        Assert.AreEqual(expected, s.IntToRoman(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 58;
        var expected = "LVIII";
        Assert.AreEqual(expected, s.IntToRoman(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = 1994;
        var expected = "MCMXCIV";
        Assert.AreEqual(expected, s.IntToRoman(input));
    }
}