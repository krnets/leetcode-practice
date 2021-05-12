using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "lee(t(c)o)de)";
        var expected = "lee(t(c)o)de";
        Assert.AreEqual(expected, s.MinRemoveToMakeValid(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "a)b(c)d";
        var expected = "ab(c)d";
        Assert.AreEqual(expected, s.MinRemoveToMakeValid(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "))((";
        var expected = "";
        Assert.AreEqual(expected, s.MinRemoveToMakeValid(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "(a(b(c)d)";
        var expected = "a(b(c)d)";
        Assert.AreEqual(expected, s.MinRemoveToMakeValid(input));
    }
}