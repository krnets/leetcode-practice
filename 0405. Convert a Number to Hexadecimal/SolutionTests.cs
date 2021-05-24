using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int num = 26;
        var expected = "1a";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }

    [Test]
    public void ExampleTest2()
    {
        int num = -1;
        var expected = "ffffffff";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }

    [Test]
    public void ExampleTest3()
    {
        int num = 1337;
        var expected = "539";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }

    [Test]
    public void ExampleTest4()
    {
        int num = 256;
        var expected = "100";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }

    [Test]
    public void ExampleTest5()
    {
        int num = -256;
        var expected = "ffffff00";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }


    [Test]
    public void ExampleTest6()
    {
        int num = 0;
        var expected = "0";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }

    [Test]
    public void ExampleTest7()
    {
        int num = 11;
        var expected = "b";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }

    [Test]
    public void ExampleTest8()
    {
        int num = -2;
        var expected = "fffffffe";
        Assert.AreEqual(expected, new Solution().ToHex(num));
    }
}