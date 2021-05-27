using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var s = "a0b1c2";
        var expected = "0a1b2c";
        Assert.AreEqual(expected, new Solution().Reformat(s));
    }

    [Test]
    public void ExampleTest2()
    {
        var s = "leetcode";
        var expected = "";
        Assert.AreEqual(expected, new Solution().Reformat(s));
    }

    [Test]
    public void ExampleTest3()
    {
        var s = "1229857369";
        var expected = "";
        Assert.AreEqual(expected, new Solution().Reformat(s));
    }

    [Test]
    public void ExampleTest4()
    {
        var s = "covid2019";
        var expected = "c2o0v1i9d";
        Assert.AreEqual(expected, new Solution().Reformat(s));
    }

    [Test]
    public void ExampleTest5()
    {
        var s = "ab123";
        var expected = "1a2b3";
        Assert.AreEqual(expected, new Solution().Reformat(s));
    }
}