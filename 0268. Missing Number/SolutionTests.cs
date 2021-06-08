using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {3, 0, 1};
        int expected = 2;
        Assert.AreEqual(expected, new Solution().MissingNumber(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {0, 1};
        int expected = 2;
        Assert.AreEqual(expected, new Solution().MissingNumber(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {9, 6, 4, 2, 3, 5, 7, 0, 1};
        int expected = 8;
        Assert.AreEqual(expected, new Solution().MissingNumber(nums));
    }

    [Test]
    public void ExampleTest4()
    {
        int[] nums = {0};
        int expected = 1;
        Assert.AreEqual(expected, new Solution().MissingNumber(nums));
    }

    [Test]
    public void ExampleTest5()
    {
        int[] nums = {1};
        int expected = 0;
        Assert.AreEqual(expected, new Solution().MissingNumber(nums));
    }
}