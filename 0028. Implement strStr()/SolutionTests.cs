using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var haystack = "hello";
        var needle = "ll";
        var expected = 2;
        Assert.AreEqual(expected, s.StrStr(haystack, needle));
    }

    [Test]
    public void ExampleTest2()
    {
        var haystack = "aaaaa";
        var needle = "bba";
        var expected = -1;
        Assert.AreEqual(expected, s.StrStr(haystack, needle));
    }

    [Test]
    public void ExampleTest3()
    {
        var haystack = "";
        var needle = "";
        var expected = 0;
        Assert.AreEqual(expected, s.StrStr(haystack, needle));
    }

    [Test]
    public void ExampleTest4()
    {
        var haystack = "";
        var needle = "a";
        var expected = -1;
        Assert.AreEqual(expected, s.StrStr(haystack, needle));
    }

    [Test]
    public void ExampleTest5()
    {
        var haystack = "aaa";
        var needle = "aaaa";
        var expected = -1;
        Assert.AreEqual(expected, s.StrStr(haystack, needle));
    }

    [Test]
    public void ExampleTest6()
    {
        var haystack = "a";
        var needle = "a";
        var expected = 0;
        Assert.AreEqual(expected, s.StrStr(haystack, needle));
    }
}