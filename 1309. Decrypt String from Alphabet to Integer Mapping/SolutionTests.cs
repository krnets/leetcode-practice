using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "10#11#12";
        var expected = "jkab";
        Assert.AreEqual(expected, s.FreqAlphabets(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "1326#";
        var expected = "acz";
        Assert.AreEqual(expected, s.FreqAlphabets(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "25#";
        var expected = "y";
        Assert.AreEqual(expected, s.FreqAlphabets(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#";
        var expected = "abcdefghijklmnopqrstuvwxyz";
        Assert.AreEqual(expected, s.FreqAlphabets(input));
    }
}