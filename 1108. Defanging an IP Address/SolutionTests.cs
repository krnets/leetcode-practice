using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "1.1.1.1";
        var expected = "1[.]1[.]1[.]1";
        Assert.AreEqual(expected, s.DefangIPaddr(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "255.100.50.0";
        var expected = "255[.]100[.]50[.]0";
        Assert.AreEqual(expected, s.DefangIPaddr(input));
    }
}