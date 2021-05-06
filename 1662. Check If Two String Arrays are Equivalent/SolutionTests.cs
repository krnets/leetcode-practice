using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        string[] word1 = {"ab", "c"};
        string[] word2 = {"a", "bc"};
        var expected = true;
        Assert.AreEqual(expected, s.ArrayStringsAreEqual(word1, word2));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] word1 = {"a", "cb"};
        string[] word2 = {"ab", "c"};
        var expected = false;
        Assert.AreEqual(expected, s.ArrayStringsAreEqual(word1, word2));
    }

    [Test]
    public void ExampleTest3()
    {
        string[] word1 = {"a", "cb"};
        string[] word2 = {"ab", "c"};
        var expected = false;
        Assert.AreEqual(expected, s.ArrayStringsAreEqual(word1, word2));
    }
}