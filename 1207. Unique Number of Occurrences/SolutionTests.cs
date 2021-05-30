using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] input = {1, 2, 2, 1, 1, 3};
        var expected = true;
        Assert.AreEqual(expected, new Solution().UniqueOccurrences(input));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] input = {1, 2};
        var expected = false;
        Assert.AreEqual(expected, new Solution().UniqueOccurrences(input));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] input = {-3, 0, 1, -3, 1, 1, 1, -3, 10, 0};
        var expected = true;
        Assert.AreEqual(expected, new Solution().UniqueOccurrences(input));
    }
}