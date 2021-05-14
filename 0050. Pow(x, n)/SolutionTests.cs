using NUnit.Framework;

public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        var x = 2.00000;
        int n = 10;
        var expected = 1024.00000;
        Assert.AreEqual(expected, s.MyPow(x, n));
    }

    [Test]
    public void ExampleTest2()
    {
        var x = 2.10000;
        var n = 3;
        var expected = 9.261000000000001d;
        Assert.AreEqual(expected, s.MyPow(x, n));
    }

    [Test]
    public void ExampleTest3()
    {
        var x = 2.00000;
        int n = -2;
        var expected = 0.25000;
        Assert.AreEqual(expected, s.MyPow(x, n));
    }

    [Test]
    public void ExampleTest4()
    {
        var x = 0.00001;
        int n = 2147483647;
        var expected = 0.0d;
        Assert.AreEqual(expected, s.MyPow(x, n));
    }
}