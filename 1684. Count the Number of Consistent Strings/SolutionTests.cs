using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string allowed = "ab";
        string[] words = {"ad", "bd", "aaab", "baa", "badab"};
        var expected = 2;
        Assert.AreEqual(expected, s.CountConsistentStrings(allowed, words));
    }

    [Test]
    public void ExampleTest2()
    {
        var allowed = "abc";
        string[] words = {"a", "b", "c", "ab", "ac", "bc", "abc"};
        var expected = 7;
        Assert.AreEqual(expected, s.CountConsistentStrings(allowed, words));
    }

    [Test]
    public void ExampleTest3()
    {
        var allowed = "cad";
        string[] words = {"cc", "acd", "b", "ba", "bac", "bad", "ac", "d"};
        var expected = 4;
        Assert.AreEqual(expected, s.CountConsistentStrings(allowed, words));
    }
}