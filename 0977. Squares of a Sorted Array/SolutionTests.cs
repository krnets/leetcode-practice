using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {-4, -1, 0, 3, 10};
        int[] expected = {0, 1, 9, 16, 100};
        Assert.AreEqual(expected, new Solution().SortedSquares(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {-7, -3, 2, 3, 11};
        int[] expected = {4, 9, 9, 49, 121};
        Assert.AreEqual(expected, new Solution().SortedSquares(nums));
    }
}