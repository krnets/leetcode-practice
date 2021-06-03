using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = 3;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().Tribonacci(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 4;
        var expected = 4;
        Assert.AreEqual(expected, new Solution().Tribonacci(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 25;
        var expected = 1389537;
        Assert.AreEqual(expected, new Solution().Tribonacci(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 0;
        var expected = 0;
        Assert.AreEqual(expected, new Solution().Tribonacci(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = 1;
        var expected = 1;
        Assert.AreEqual(expected, new Solution().Tribonacci(input));
    }

    [Test]
    public void ExampleTest6()
    {
        var input = 2;
        var expected = 1;
        Assert.AreEqual(expected, new Solution().Tribonacci(input));
    }
}