using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int x = 1;
        int y = 4;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().HammingDistance(x, y));
    }

    [Test]
    public void ExampleTest2()
    {
        int x = 3;
        int y = 1;
        var expected = 1;
        Assert.AreEqual(expected, new Solution().HammingDistance(x, y));
    }
}