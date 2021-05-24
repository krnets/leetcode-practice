using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var num = 5;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().FindComplement(num));
    }

    [Test]
    public void ExampleTest2()
    {
        var num = 1;
        var expected = 0;
        Assert.AreEqual(expected, new Solution().FindComplement(num));
    }

    [Test]
    public void ExampleTest3()
    {
        var num = 42;
        var expected = 21;
        Assert.AreEqual(expected, new Solution().FindComplement(num));
    }

    [Test]
    public void ExampleTest4()
    {
        var num = 219;
        var expected = 36;
        Assert.AreEqual(expected, new Solution().FindComplement(num));
    }

    [Test]
    public void ExampleTest5()
    {
        var num = 273;
        var expected = 238;
        Assert.AreEqual(expected, new Solution().FindComplement(num));
    }

    [Test]
    public void ExampleTest6()
    {
        var num = 2184;
        var expected = 1911;
        Assert.AreEqual(expected, new Solution().FindComplement(num));
    }
}