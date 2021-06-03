using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = 2;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 3;
        var expected = 3;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest3()
    {
        var input = 4;
        var expected = 5;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest4()
    {
        var input = 5;
        var expected = 8;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest5()
    {
        var input = 6;
        var expected = 13;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest6()
    {
        var input = 7;
        var expected = 21;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest7()
    {
        var input = 30;
        var expected = 1346269;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }

    [Test]
    public void ExampleTest8()
    {
        var input = 60;
        var expected = 764848393;
        Assert.AreEqual(expected, new Solution().ClimbStairs(input));
    }
}