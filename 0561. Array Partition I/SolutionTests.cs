using NUnit.Framework;

[Parallelizable(scope: ParallelScope.All)]
public class SolutionTests
{
    Solution s = new();

    [Test]
    public void ExampleTest1()
    {
        int[] nums = {1, 4, 3, 2};
        int expected = 4;
        Assert.AreEqual(expected, s.ArrayPairSum(nums));
    }

    [Test]
    public void ExampleTest2()
    {
        int[] nums = {6, 2, 6, 5, 1, 2};
        int expected = 9;
        Assert.AreEqual(expected, s.ArrayPairSum(nums));
    }
}