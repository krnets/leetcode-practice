using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var s = "abcd";
        var t = "abcde";
        var expected = 'e';
        Assert.AreEqual(expected, new Solution().FindTheDifference(s, t));
    }

    [Test]
    public void ExampleTest2()
    {
        var s = "";
        var t = "y";
        var expected = 'y';
        Assert.AreEqual(expected, new Solution().FindTheDifference(s, t));
    }

    [Test]
    public void ExampleTest3()
    {
        var s = "a";
        var t = "aa";
        var expected = 'a';
        Assert.AreEqual(expected, new Solution().FindTheDifference(s, t));
    }

    [Test]
    public void ExampleTest4()
    {
        var s = "ae";
        var t = "aea";
        var expected = 'a';
        Assert.AreEqual(expected, new Solution().FindTheDifference(s, t));
    }
}