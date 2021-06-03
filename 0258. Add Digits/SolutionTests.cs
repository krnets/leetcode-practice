using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        var input = 38;
        var expected = 2;
        Assert.AreEqual(expected, new Solution().AddDigits(input));
    }

    [Test]
    public void ExampleTest2()
    {
        var input = 0;
        var expected = 0;
        Assert.AreEqual(expected, new Solution().AddDigits(input));
    }
}