using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var num = 9669;
        var expected = 9969;
        Assert.AreEqual(expected, s.Maximum69Number(num));
    }

    [Test]
    public void ExampleTest2()
    {
        var num = 9996;
        var expected = 9999;
        Assert.AreEqual(expected, s.Maximum69Number(num));
    }

    [Test]
    public void ExampleTest3()
    {
        var num = 9999;
        var expected = 9999;
        Assert.AreEqual(expected, s.Maximum69Number(num));
    }
}