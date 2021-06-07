using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 3, 4, 2, 2};
        var expected = 2;
        Assert.AreEqual(expected, new Solution().FindDuplicate(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {3, 1, 3, 4, 2};
        var expected = 3;
        Assert.AreEqual(expected, new Solution().FindDuplicate(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {1, 1};
        var expected = 1;
        Assert.AreEqual(expected, new Solution().FindDuplicate(nums));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums = {1, 1, 2};
        var expected = 1;
        Assert.AreEqual(expected, new Solution().FindDuplicate(nums));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] nums = {2, 5, 9, 6, 9, 3, 8, 9, 7, 1};
        var expected = 9;
        Assert.AreEqual(expected, new Solution().FindDuplicate(nums));
    }
}
