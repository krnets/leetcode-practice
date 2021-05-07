using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var word1 = "abc";
        var word2 = "pqr";
        var expected = "apbqcr";
        Assert.AreEqual(expected, s.MergeAlternately(word1, word2));
    }

    [Test]
    public void ExampleTest2()
    {
        var word1 = "ab";
        var word2 = "pqrs";
        var expected = "apbqrs";
        Assert.AreEqual(expected, s.MergeAlternately(word1, word2));
    }

    [Test]
    public void ExampleTest3()
    {
        var word1 = "abcd";
        var word2 = "pq";
        var expected = "apbqcd";
        Assert.AreEqual(expected, s.MergeAlternately(word1, word2));
    }
}