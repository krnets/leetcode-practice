using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = 5;
        var expected = true;
        Assert.AreEqual(expected, new Solution().HasAlternatingBits(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 7;
        var expected = false;
        Assert.AreEqual(expected, new Solution().HasAlternatingBits(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 11;
        var expected = false;
        Assert.AreEqual(expected, new Solution().HasAlternatingBits(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 10;
        var expected = true;
        Assert.AreEqual(expected, new Solution().HasAlternatingBits(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = 3;
        var expected = false;
        Assert.AreEqual(expected, new Solution().HasAlternatingBits(input));
    }
}