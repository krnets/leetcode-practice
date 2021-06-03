using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {2, 2, 3, 4};
        var expected = 3;
        Assert.AreEqual(expected, new Solution().TriangleNumber(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {4, 2, 3, 4};
        var expected = 4;
        Assert.AreEqual(expected, new Solution().TriangleNumber(nums));
    }
}