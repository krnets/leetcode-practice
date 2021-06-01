using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1};
        int k = 0;
        int expected = 0;
        Assert.AreEqual(expected, new Solution().SmallestRangeI(nums, k));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {0, 10};
        int k = 2;
        int expected = 6;
        Assert.AreEqual(expected, new Solution().SmallestRangeI(nums, k));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 3, 6};
        int k = 3;
        int expected = 0;
        Assert.AreEqual(expected, new Solution().SmallestRangeI(nums, k));
    }
}