using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string[] words = {"i", "love", "leetcode", "i", "love", "coding"};
        int k = 2;
        string[] expected = {"i", "love"};
        Assert.AreEqual(expected, new Solution().TopKFrequent(words, k));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] words = {"the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"};
        int k = 4;
        string[] expected = {"the", "is", "sunny", "day"};
        Assert.AreEqual(expected, new Solution().TopKFrequent(words, k));
    }

    [Test]
    public void ExampleTest3()
    {
        string[] words = {"i", "love", "leetcode", "i", "love", "coding"};
        int k = 3;
        string[] expected = {"i", "love", "coding"};
        Assert.AreEqual(expected, new Solution().TopKFrequent(words, k));
    }
}