using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var input = "aaaabbbbcccc";
        var expected = "abccbaabccba";
        Assert.AreEqual(expected, s.SortString(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = "rat";
        var expected = "art";
        Assert.AreEqual(expected, s.SortString(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = "leetcode";
        var expected = "cdelotee";
        Assert.AreEqual(expected, s.SortString(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = "ggggggg";
        var expected = "ggggggg";
        Assert.AreEqual(expected, s.SortString(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = "spo";
        var expected = "ops";
        Assert.AreEqual(expected, s.SortString(input));
    }
}