using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string[] words = {"abc", "deq", "mee", "aqq", "dkd", "ccc"};
        var pattern = "abb";
        string[] expected = {"mee", "aqq"};
        Assert.AreEqual(expected, new Solution().FindAndReplacePattern(words, pattern));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] words = {"a", "b", "c"};
        var pattern = "a";
        string[] expected = {"a", "b", "c"};
        Assert.AreEqual(expected, new Solution().FindAndReplacePattern(words, pattern));
    }

    [Test]
    public void ExampleTest3()
    {
        string[] words = {"aa", "bb", "ab", "cd"};
        var pattern = "aa";
        string[] expected = {"aa", "bb"};
        Assert.AreEqual(expected, new Solution().FindAndReplacePattern(words, pattern));
    }
}