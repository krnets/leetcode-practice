using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 2, 4};
        int[] expected = {2, 3};
        Assert.AreEqual(expected, new Solution().FindErrorNums(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 1};
        int[] expected = {1, 2};
        Assert.AreEqual(expected, new Solution().FindErrorNums(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {2, 2};
        int[] expected = {2, 1};
        Assert.AreEqual(expected, new Solution().FindErrorNums(nums));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums = {3, 3, 1};
        int[] expected = {3, 2};
        Assert.AreEqual(expected, new Solution().FindErrorNums(nums));
    }
}