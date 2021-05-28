using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 3};
        int expected = 6;
        Assert.AreEqual(expected, new Solution().SubsetXORSum(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {5, 1, 6};
        int expected = 28;
        Assert.AreEqual(expected, new Solution().SubsetXORSum(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {3, 4, 5, 6, 7, 8};
        int expected = 480;
        Assert.AreEqual(expected, new Solution().SubsetXORSum(nums));
    }
}