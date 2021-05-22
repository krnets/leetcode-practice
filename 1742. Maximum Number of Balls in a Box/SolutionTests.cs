using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var lowLimit = 1;
        var highLimit = 10;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().CountBalls(lowLimit, highLimit));
    }

    [Test]
    public void ExampleTest2()
    {
        var lowLimit = 5;
        var highLimit = 15;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().CountBalls(lowLimit, highLimit));
    }
}