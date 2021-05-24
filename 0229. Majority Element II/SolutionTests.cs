using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {3, 2, 3};
        int[] expected = {3};
        Assert.AreEqual(expected, new Solution().MajorityElement(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1};
        int[] expected = {1};
        Assert.AreEqual(expected, new Solution().MajorityElement(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 2};
        int[] expected = {1, 2};
        Assert.AreEqual(expected, new Solution().MajorityElement(nums));
    }
}