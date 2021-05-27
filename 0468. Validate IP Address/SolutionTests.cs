using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var IP = "172.16.254.1";
        var expected = "IPv4";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest2()
    {
        var IP = "2001:0db8:85a3:0:0:8A2E:0370:7334";
        var expected = "IPv6";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest3()
    {
        var IP = "256.256.256.256";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest4()
    {
        var IP = "2001:0db8:85a3:0:0:8A2E:0370:7334:";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest5()
    {
        var IP = "1e1.4.5.6";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest6()
    {
        var IP = "01.01.01.01";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest7()
    {
        var IP = "1.1.1.1.";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest8()
    {
        var IP = "2001:0db8:85a3:00000:0:8A2E:0370:7334";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest9()
    {
        var IP = "192.0.0.1";
        var expected = "IPv4";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest10()
    {
        var IP = "192.168.1.1";
        var expected = "IPv4";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest11()
    {
        var IP = "192.168.1.0";
        var expected = "IPv4";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest12()
    {
        var IP = "192.168.01.1";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest13()
    {
        var IP = "192.168.1.00";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }

    [Test]
    public void ExampleTest14()
    {
        var IP = "192.168@1.1";
        var expected = "Neither";
        Assert.AreEqual(expected, new Solution().ValidIPAddress(IP));
    }
}