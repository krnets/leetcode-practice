using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var s = "abcdefg";
        int k = 2;
        var expected = "bacdfeg";
        Assert.AreEqual(expected, new Solution().ReverseStr(s, k));
    }

    [Test]
    public void ExampleTest2()
    {
        var s = "abcd";
        int k = 2;
        var expected = "bacd";
        Assert.AreEqual(expected, new Solution().ReverseStr(s, k));
    }

    [Test]
    public void ExampleTest3()
    {
        var s = "a";
        int k = 2;
        var expected = "a";
        Assert.AreEqual(expected, new Solution().ReverseStr(s, k));
    }

    [Test]
    public void ExampleTest4()
    {
        var s = "abcdefg";
        int k = 3;
        var expected = "cbadefg";
        Assert.AreEqual(expected, new Solution().ReverseStr(s, k));
    }

    [Test]
    public void ExampleTest5()
    {
        var s = "abcdefg";
        int k = 8;
        var expected = "gfedcba";
        Assert.AreEqual(expected, new Solution().ReverseStr(s, k));
    }
}