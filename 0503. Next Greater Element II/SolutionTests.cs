using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 2, 1};
        int[] expected = {2, -1, 2};
        Assert.AreEqual(expected, new Solution().NextGreaterElements(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {1, 2, 3, 4, 3};
        int[] expected = {2, 3, 4, -1, 4};
        Assert.AreEqual(expected, new Solution().NextGreaterElements(nums));
    }

    [Test]
    public void ExampleTest3()
    {
        int[] nums = {5, 4, 3, 2, 1};
        int[] expected = {-1, 5, 5, 5, 5};
        Assert.AreEqual(expected, new Solution().NextGreaterElements(nums));
    }
}