using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var s = "leetcode";
        var expected = 0;
        Assert.AreEqual(expected, new Solution().FirstUniqChar(s));
    }

    [Test]
    public void ExampleTest2()
    {
        var s = "loveleetcode";
        var expected = 2;
        Assert.AreEqual(expected, new Solution().FirstUniqChar(s));
    }

    [Test]
    public void ExampleTest3()
    {
        var s = "aabb";
        var expected = -1;
        Assert.AreEqual(expected, new Solution().FirstUniqChar(s));
    }
}