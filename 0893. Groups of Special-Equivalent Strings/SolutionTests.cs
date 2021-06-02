using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        string[] words = {"abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"};
        int expected = 3;
        Assert.AreEqual(expected, new Solution().NumSpecialEquivGroups(words));
    }

    [Test]
    public void ExampleTest2()
    {
        string[] words = {"abc", "acb", "bac", "bca", "cab", "cba"};
        int expected = 3;
        Assert.AreEqual(expected, new Solution().NumSpecialEquivGroups(words));
    }
}