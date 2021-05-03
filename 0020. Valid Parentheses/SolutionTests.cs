using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void Test1()
    {
        Assert.AreEqual(true, s.IsValid("()"));
    }

    [Test]
    public void Test2()
    {
        Assert.AreEqual(true, s.IsValid("()[]{}"));
    }

    [Test]
    public void Test3()
    {
        Assert.AreEqual(false, s.IsValid("(]"));
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(false, s.IsValid("([)]"));
    }

    [Test]
    public void Test5()
    {
        Assert.AreEqual(true, s.IsValid("{[]}"));
    }
}