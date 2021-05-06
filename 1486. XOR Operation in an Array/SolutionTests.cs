using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int n = 5;
        int start = 0;
        var expected = 8;
        Assert.AreEqual(expected, s.XorOperation(n, start));
    }

    [Test]
    public void ExampleTest2()
    {
        int n = 4;
        int start = 3;
        var expected = 8;
        Assert.AreEqual(expected, s.XorOperation(n, start));
    }

    [Test]
    public void ExampleTest3()
    {
        int n = 1;
        int start = 7;
        var expected = 7;
        Assert.AreEqual(expected, s.XorOperation(n, start));
    }

    [Test]
    public void ExampleTest4()
    {
        int n = 10;
        int start = 5;
        var expected = 2;
        Assert.AreEqual(expected, s.XorOperation(n, start));
    }
}