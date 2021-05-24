using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {3, 2, 3};
        var expected = 3;
        Assert.AreEqual(expected, new Solution().MajorityElement(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {2, 2, 1, 1, 1, 2, 2};
        var expected = 2;
        Assert.AreEqual(expected, new Solution().MajorityElement(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {-1, 1, 1, 1, 2, 1};
        var expected = 1;
        Assert.AreEqual(expected, new Solution().MajorityElement(nums));
    }
}