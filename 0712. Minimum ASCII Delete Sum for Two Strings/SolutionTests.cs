using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var s1 = "sea";
        var s2 = "eat";
        var expected = 231;
        Assert.AreEqual(expected, new Solution().MinimumDeleteSum(s1, s2));
    }

    [Test]
    public void ExampleTest2()
    {
        var s1 = "delete";
        var s2 = "leet";
        var expected = 403;
        Assert.AreEqual(expected, new Solution().MinimumDeleteSum(s1, s2));
    }
}